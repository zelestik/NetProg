using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using NetProg4;
using System.IO;
using System.Diagnostics;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        readonly static int RemotePort = 8350; // порт для отправки сообщений
        static Socket listeningSocket;
        bool isConnectionStarted = false;
        bool isConnected = false;
        readonly fmXO FormXO;
        public string FileName = null;
        public int tst = 0;
        public int filesize = 255;
        // bool IsAdmin;

        public Form1()
        {
            InitializeComponent();
            FormXO = new fmXO(this);
        }

        void ConnectUser()
        {
            if (!isConnectionStarted)
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                Task listeningTask = new Task(Listen);
                listeningTask.Start();
                tbPort.Enabled = false;
                tbUser.Enabled = false;
                buGetAdmin.Enabled = true;
                bConnDicon.Text = "Отключиться";
                isConnectionStarted = true;
                buXO.Enabled = true;
                GetSound.Visible = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnectionStarted)
            {
                if (isConnected)
                {
                    byte[] data1 = Encoding.Unicode.GetBytes("-1|" + tbUser.Text);
                    EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), RemotePort);
                    listeningSocket.SendTo(data1, remotePoint);
                    isConnected = false;
                }
                tbUser.Enabled = true;
                tbPort.Enabled = true;
                bConnDicon.Text = "Подключиться";
                isConnectionStarted = false;
                // IsAdmin = false;
                buGetAdmin.Enabled = false;
                adminPanel.Enabled = false;
                buXO.Enabled = false;
                CloseSocket();
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (isConnectionStarted)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }

        }

        public void MsgCallback(string msg)
        {
            lvMessages.Items.Add(msg);
        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                byte[] data = Encoding.Unicode.GetBytes("0|" + tbMessage.Text);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), RemotePort);
                listeningSocket.SendTo(data, remotePoint);
                tbMessage.Text = string.Empty;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectUser();
        }

        private void Listen()
        {
            try
            {
                //Прослушиваем по адресу
                IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Int32.Parse(tbPort.Text));
                listeningSocket.Bind(localIP);

                byte[] data1 = Encoding.Unicode.GetBytes("1|" + tbUser.Text);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), RemotePort);
                listeningSocket.SendTo(data1, remotePoint);
                while (true)
                {
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[filesize + 50]; // буфер для получаемых данных

                    //адрес, с которого пришли данные
                    EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);
                    
                    do
                    {
                        bytes = listeningSocket.ReceiveFrom(data, ref remoteIp);
                        if (FileName == null)
                        {
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        } 
                        else
                        {
                            string path = "";
                            File.WriteAllBytes(path + FileName, data);                           
                        }
                    }
                    while (listeningSocket.Available > 0);
                    string str = builder.ToString();
                    string[] SplittedInfo = new string[32];
                    if (FileName == null)
                    {
                        SplittedInfo = str.Split('|');
                    } 
                    else
                    {
                        string path =  FileName;

                        if (File.Exists(string.Format(path, string.Empty)))
                            Process.Start(string.Format(path, string.Empty));
                        else if (File.Exists(string.Format(path, " (x86)")))
                            Process.Start(string.Format(path, " (x86)"));
                        else
                            MessageBox.Show("Ошибка файл не найден ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FileName = null;
                        filesize = 255;
                    }
                    // получаем данные о подключении
                    IPEndPoint remoteFullIp = remoteIp as IPEndPoint;
                    switch (SplittedInfo[0])
                    {
                        case "0":
                            // выводим сообщение
                            lvMessages.Invoke(new Action(() => { lvMessages.Items.Add(SplittedInfo[1]); }));
                            break;
                        case "1":
                            try
                            {
                                switch (SplittedInfo[1])
                                {
                                    case "0":
                                        isConnected = true;
                                        new Task(() =>
                                        {
                                            MessageBox.Show(
                                                    SplittedInfo[2], "Успешно", 
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information
                                                );
                                        }).Start();
                                        break;
                                    case "1":
                                        DisconnectUser();
                                        new Task(() => {
                                            MessageBox.Show(
                                                    SplittedInfo[2], 
                                                    "Ошибка", 
                                                    MessageBoxButtons.OK, 
                                                    MessageBoxIcon.Error
                                                );
                                        }).Start();
                                        break;
                                }
                            }
                            catch(Exception e)
                            {
                                DisconnectUser();
                                new Task(() => {
                                    MessageBox.Show(
                                            e.Message, 
                                            "Ошибка", 
                                            MessageBoxButtons.OK, 
                                            MessageBoxIcon.Error
                                        );
                                }).Start();
                            }
                            break;
                        case "2":
                            try
                            {
                                switch (SplittedInfo[1])
                                {
                                    case "0":
                                        // IsAdmin = true;
                                        buGetAdmin.Invoke(new Action(() => { buGetAdmin.Enabled = false; }));
                                        adminPanel.Invoke(new Action(() => { adminPanel.Enabled = true; }));
                                        MessageBox.Show(SplittedInfo[2], "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    case "1":
                                        MessageBox.Show(SplittedInfo[2], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            catch
                            {
                                DisconnectUser();
                                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case "3":
                            try
                            {
                                switch (SplittedInfo[1]) {
                                    case "White":
                                        Invoke(new Action(() => { BackColor = Color.White; }));
                                        foreach (Control control in Controls)
                                        {
                                            if (control is Label label)
                                                label.ForeColor = Color.Black;
                                            else if (control is Panel panel)
                                                foreach (Control cop in panel.Controls)
                                                    if (cop is Label lab)
                                                        lab.ForeColor = Color.Black;
                                        }
                                        break;
                                    case "Black":
                                        Invoke(new Action(() => { BackColor = Color.Black; }));
                                        foreach (Control control in Controls)
                                        {
                                            if (control is Label label)
                                                label.ForeColor = Color.White;
                                            else if (control is Panel panel)
                                                foreach (Control cop in panel.Controls)
                                                    if (cop is Label lab)
                                                        lab.ForeColor = Color.White;
                                        }
                                        break;
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Не удалось изменить цвет окна");
                            }
                            break;
                        case "XO":
                            switch (SplittedInfo[1])
                            {
                                case "Play":
                                    FormXO.AppendPropsBtn(
                                            int.Parse(SplittedInfo[2]),
                                            int.Parse(SplittedInfo[3]),
                                            SplittedInfo[4],
                                            SplittedInfo[5]
                                        );
                                    break;
                                case "0":
                                    MessageBox.Show(SplittedInfo[2]);
                                    Invoke(new Action(() =>
                                    {
                                        FormXO.Show();
                                    }));
                                    break;
                                case "1":
                                    MessageBox.Show(SplittedInfo[2]);
                                    break;
                                case "2":
                                    MessageBox.Show(SplittedInfo[2]);
                                    FormXO.Invoke(
                                            (MethodInvoker) delegate
                                            {
                                                FormXO.HideWindow();
                                            }
                                        );
                                    break;
                            }
                            break;
                        case "File":
                            FileName = SplittedInfo[1];
                            int.TryParse(SplittedInfo[2], out filesize);
                            break;
                        case "Admin":
                            string ChaosListUser = SplittedInfo[1];
                            Invoke(
                                    (MethodInvoker)delegate
                                    {
                                        FillControlForm(ChaosListUser);
                                    }
                                );
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }

        public void FillControlForm(string users)
        {
            UsersCheckBox.Items.Clear();
            string[] UserList = users.Split('\n');

            foreach (string user in UserList)
            {
                string[] UserInfo = user.Split('/');
                if (UserInfo.Length > 2)
                {
                    int i = UsersCheckBox.Items.Add(UserInfo[0] + "|" + UserInfo[1]);
                    if (bool.TryParse(UserInfo[2], out bool CheckedValue))
                    {
                        UsersCheckBox.SetItemChecked(i, CheckedValue);
                    }
                }
            }

            
        }
        public void SendMsg(string msg)
        {
            try
            {
                byte[] dataToSend = Encoding.Unicode.GetBytes(msg);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), RemotePort);
                listeningSocket.SendTo(dataToSend, remotePoint);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private static void CloseSocket()
        {
            if (listeningSocket != null)
            {
                listeningSocket.Shutdown(SocketShutdown.Both);
                listeningSocket.Close();
                listeningSocket = null;
            }
        }

        private void BuGetAdmin_Click(object sender, EventArgs e)
        {
            SendMsg("2|"+ tbUser.Text);
        }

        private void BuBlack_Click(object sender, EventArgs e)
        {
            SendMsg("3|Black");
        }

        private void BuWhite_Click(object sender, EventArgs e)
        {
            SendMsg("3|White");
        }

        private void BuXO_Click(object sender, EventArgs e)
        {
            SendMsg("XO|Start");
        }

        private void GetSound_Click(object sender, EventArgs e)
        {
            SendMsg("Sound");
        }

        private void UsersCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SendMsg("UpdListUsers|" + UsersCheckBox.Items[e.Index].ToString() + "|" + e.NewValue.ToString());
        }
    }
}
