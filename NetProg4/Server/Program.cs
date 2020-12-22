using System;
using System.Collections.Generic;
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
        public User(int port, string username)
        {
            this.Port = port;
            this.Username = username;
        }
    }
    class Program
    {
        static int localPort = 8350; // порт приема сообщений
        static int remotePort; // порт для отправки сообщений
        static Socket listeningSocket;
        static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            try
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                Task listeningTask = new Task(Listen);
                listeningTask.Start();
                while (true) // регистрация пользователей
                {
                    Console.WriteLine("Для регистрация пользователя укажите порт пользователя");
                    int port = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите имя пользователя");
                    string username = Console.ReadLine();
                    var user = new User(port, username);
                    users.Add(user);
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

        // поток для приема подключений
        private static void Listen()
        {
            try
            {
                //Прослушиваем по адресу
                IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), localPort);
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
                    // получаем данные о подключении
                    IPEndPoint remoteFullIp = remoteIp as IPEndPoint;
                    
                    // выводим сообщение
                    foreach (var user in users)
                    {
                        if(user.Port == remoteFullIp.Port)
                        {
                            string msg = DateTime.Now.ToShortTimeString() + " " + user.Username + ": " + builder.ToString();
                            Console.WriteLine(msg);
                            foreach (var userToSend in users)
                            {
                                byte[] dataToSend = Encoding.Unicode.GetBytes(msg);
                                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), userToSend.Port);
                                listeningSocket.SendTo(dataToSend, remotePoint);
                            }
                        }
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
    }
}
