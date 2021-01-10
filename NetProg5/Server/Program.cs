using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class User
    {
        public int Port;
        public string Username;
        public bool IsOnline = false;
        public bool GetMsg;
        public User(int port, string username, bool isOnline)
        {
            Port = port;
            Username = username;
            IsOnline = isOnline;
            GetMsg = false;
        }
    }

    class Program
    {
        static readonly int servicesPort = 8350; // порт для обработки других действий
        static Socket listeningSocket;
        public static List<User> users = new List<User>();
        static User admin;
        static User firstXOPlayer;
        static User secondXOPlayer;
        static int stepsCountXO = 0;
        static void Main()
        {
            try
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                Task listeningTaskServices = new Task(ListenForService);
                listeningTaskServices.Start();
                Task timer = new Task(Timer);
                timer.Start();
                Console.WriteLine("Для выхода нажмите на любую кнопку");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Close();
            }
        }
        private static void ListenForService()
        {
            try
            {
                //Прослушиваем по адресу
                IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), servicesPort);
                listeningSocket.Bind(localIP);

                while (true)
                {
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[256]; // буфер для получаемых данных

                    //адрес, с которого пришли данные
                    EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);

                    do
                    {
                        bytes = listeningSocket.ReceiveFrom(data, ref remoteIp);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (listeningSocket.Available > 0);
                    string str = builder.ToString();
                    // получаем данные о подключении
                    IPEndPoint remoteFullIp = remoteIp as IPEndPoint;
                    string[] SplittedInfo = str.Split('|');
                    switch (SplittedInfo[0])
                    {
                        case "0": // приём и пересылка сообщений
                            foreach (User user in users)
                            {
                                if (user.Port == remoteFullIp.Port)
                                {
                                    string msg = "0|" + DateTime.Now.ToShortTimeString() + " " + user.Username + ": " + SplittedInfo[1];
                                    Console.WriteLine(msg);
                                    foreach (var userToSend in users)
                                    {
                                        SendMsg(msg, userToSend.Port);
                                    }
                                }
                            }
                            break;

                        case "1": // регистрация пользователя
                            UserRegistration(SplittedInfo, remoteFullIp.Port);
                            if (admin != null)
                            {
                                SendMsg("0|" + SplittedInfo[1] + " вошёл в чат", admin.Port);
                                SendUsers(admin.Port);
                            }
                            break;
                        case "-1": // удаление пользователя
                            try
                            {
                                var userToDelete = users.Find(x => x.Username == SplittedInfo[1]);
                                if (userToDelete == admin)
                                {
                                    admin = null;
                                    Console.WriteLine("0|" + SplittedInfo[1] + " лишён прав администратора");
                                }
                                if (admin != null)
                                {
                                    SendMsg("0|" + userToDelete.Username + " вышел из чата", admin.Port);
                                    SendUsers(admin.Port);
                                }
                                userToDelete.IsOnline = false;
                                users.Remove(userToDelete); // пока что здесь удаление, в дальнейшем планируется лишь пометка на переход в оффлайн (isOnline = false)
                                UsersChanged();
                                Console.WriteLine(SplittedInfo[1] + " оффлайн");

                            }
                            catch 
                            {
                                Console.WriteLine("Не удалось удалить пользователя");
                            }
                            break;
                        case "2": // получение админки
                            if (admin == null)
                            {
                                try
                                {
                                    admin = users.Find(x => x.Username == SplittedInfo[1]);
                                    SendMsg("2|0|Права администратора получены", remoteFullIp.Port);
                                    SendUsers(remoteFullIp.Port);
                                    Console.WriteLine("0| " + admin.Username + " получил права администратора");
                                    foreach (var userToSend in users)
                                    {
                                        SendMsg("0| " + admin.Username + " получил права администратора", userToSend.Port);
                                    }
                                }
                                catch
                                {
                                    SendMsg("2|1|Ошибка при выдаче прав администратора", remoteFullIp.Port);
                                }
                            }
                            else
                            {
                                SendMsg("2|1|Права администратора уже выданы", remoteFullIp.Port);
                            }
                            break;
                        case "3": // смена цвета
                            if (admin.Port == remoteFullIp.Port)
                            {
                                foreach (var userToSend in users)
                                {
                                    SendMsg(str, userToSend.Port);
                                }
                            }
                            break;
                        case "XO": // крестики нолики
                            switch (SplittedInfo[1])
                            {
                                case "Start":
                                    if (firstXOPlayer is null)
                                    {
                                        firstXOPlayer = users.Find(x => x.Port == remoteFullIp.Port);
                                        SendMsg("XO|1|Ожидайте второго игрока", remoteFullIp.Port);
                                    }
                                    else if (secondXOPlayer is null)
                                    {
                                        secondXOPlayer = users.Find(x => x.Port == remoteFullIp.Port);
                                        if (secondXOPlayer != firstXOPlayer)
                                        {
                                            SendMsg(
                                                "XO|0|Игра начинается, вы ходите первым (Х)",
                                                firstXOPlayer.Port
                                            );
                                            SendMsg(
                                                    "XO|0|Игра начинается, вы ходите вторым (О)",
                                                    secondXOPlayer.Port
                                                );
                                        } 
                                        else
                                        {
                                            SendMsg(
                                                "XO|1|Вы не можете играть самим с собой",
                                                firstXOPlayer.Port
                                            );
                                            secondXOPlayer = null;
                                        }
                                    }
                                    else
                                        SendMsg("XO|1|Комната занята", remoteFullIp.Port);
                                    break;
                                case "End":
                                    stepsCountXO = 0;
                                    if (firstXOPlayer != null)
                                    {
                                        SendMsg("XO|2|Игра окончена", firstXOPlayer.Port);

                                    }
                                    else if (secondXOPlayer != null)
                                    {
                                        SendMsg("XO|2|Игра окончена", secondXOPlayer.Port);
                                    }
                                    firstXOPlayer = null;
                                    secondXOPlayer = null;
                                    break;
                                case "Play":
                                    if (firstXOPlayer != null && secondXOPlayer != null)
                                    {
                                        if (firstXOPlayer.Port == remoteFullIp.Port && (stepsCountXO % 2) == 0)
                                        {
                                            stepsCountXO++;
                                            SendMsg(str + "|X|enabled", secondXOPlayer.Port);
                                            SendMsg(str + "|X|disabled", firstXOPlayer.Port);
                                        }
                                        else if (secondXOPlayer.Port == remoteFullIp.Port && (stepsCountXO % 2) != 0)
                                        {
                                            stepsCountXO++;
                                            SendMsg(str + "|O|enabled", firstXOPlayer.Port);
                                            SendMsg(str + "|O|disabled", secondXOPlayer.Port);
                                        }
                                        if (stepsCountXO == 9)
                                        {
                                            stepsCountXO = 0;
                                            SendMsg("XO|2|Игра окончена", firstXOPlayer.Port);
                                            SendMsg("XO|2|Игра окончена", secondXOPlayer.Port);
                                        }
                                    }
                                    break;
                            }
                            break;
                        case "Sound":
                            string[] files = new string[2] { "1.mp3", "2.mp3" };
                            Random rand = new Random();
                            string FileName = files[rand.Next(2)];
                            long length = new FileInfo(FileName).Length;
                            SendMsg("File|" + FileName + "|" + length.ToString(), remoteFullIp.Port);
                            SendFile(FileName, remoteFullIp.Port);
                            break;
                        case "UpdListUsers":
                            string UserName = SplittedInfo[1];
                            string UserPort = SplittedInfo[2];
                            string UserFlag = SplittedInfo[3];
                            User ChangeUser = users.Find(x => x.Port == int.Parse(UserPort));
                            if ( UserFlag == "Checked")
                            {
                                ChangeUser.GetMsg = true;
                            }
                            else if (UserFlag == "Unchecked")
                            {
                                ChangeUser.GetMsg = false;
                            }
                            UsersChanged();
                            break;
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Close();
            }
        }
        public static void SendUsers(int port)
        {
            string UserList = File.ReadAllText("users.txt");
            SendMsg("Admin|" + UserList, port);
        }

        private static void UserRegistration(string[] SplittedInfo, int port)
        {
            try
            {
                foreach (var user in users)
                {
                    if (user.Port == port)
                    {
                        SendMsg("1|1|Данный порт занят!!!", port);
                        return;
                    }
                }
                if(port == servicesPort)
                {
                    SendMsg("1|1|Данный порт занят!!!", port);
                    return;
                }
                users.Add(new User(port, SplittedInfo[1], true));
                UsersChanged();
                SendMsg("1|0|Пользователь успешно зарегистрирован", port);
            }
            catch (Exception e)
            {
                SendMsg("1|1|Неизвестная ошибка, " + e.Message, port);
                Console.WriteLine(e.Message);
            }
        }

        private static void SendMsg(string msg, int port)
        {
            try
            {
                byte[] dataToSend = Encoding.Unicode.GetBytes(msg);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                listeningSocket.SendTo(dataToSend, remotePoint);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void SendFile(string file, int port)
        {
            try
            {
                byte[] dataToSend = File.ReadAllBytes(file);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                int len = listeningSocket.SendTo(dataToSend, remotePoint);
                Console.WriteLine(len);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // закрытие сокета
        private static void Close()
        {
            if (listeningSocket != null)
            {
                listeningSocket.Shutdown(SocketShutdown.Both);
                listeningSocket.Close();
                listeningSocket = null;
            }
        }

        static void UsersChanged()
        {
            var filename = "users.txt";
            try
            {
                string txt = "";
                foreach(var user in users)
                {
                    txt += user.Username + "/" + user.Port + "/" + user.GetMsg + "\n";
                }
                File.WriteAllText(filename, txt);
            }
            catch
            {
                Console.WriteLine("Ошибка чтения файла");
            }
        }

        private static void Timer()
        {
            while (true) 
            {

                if (DateTime.Now.Second == 00)
                {
                    string[] UserList = File.ReadAllText("users.txt").Split('\n');
                    foreach(string user in UserList)
                    {
                        string[] UserInfo = user.Split('/');
                        if (UserInfo.Length > 2 && UserInfo[2] == "False" && int.TryParse(UserInfo[1], out int UserInfoPort))
                        {
                            SendMsg(
                                    "0|Сервер: " 
                                    + "Дорогой " 
                                    + UserInfo[0]   
                                    + " сейчас" 
                                    + DateTime.Now.ToShortTimeString(),
                                    UserInfoPort
                                );
                        }
                    }
                }
                 
                System.Threading.Thread.Sleep(1000); 
            }
        }
    }
}
