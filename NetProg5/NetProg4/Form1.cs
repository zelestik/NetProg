using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Input;
using System.IO;
using System.Net;
using NetProg4;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        static int remotePort = 8350; // порт для отправки сообщений
        static Socket listeningSocket;
        bool isConnectionStarted = false;
        bool isConnected = false;
        bool isAdmin = false;

        public Form1()
        {
            InitializeComponent();
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
            }
        }

        void DisconnectUser()
        {
            if (isConnectionStarted)
            {
                if (isConnected)
                {
                    byte[] data1 = Encoding.Unicode.GetBytes("-1|" + tbUser.Text);
                    EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), remotePort);
                    listeningSocket.SendTo(data1, remotePoint);
                    isConnected = false;
                }
                tbUser.Enabled = true;
                tbPort.Enabled = true;
                bConnDicon.Text = "Подключиться";
                isConnectionStarted = false;
                isAdmin = false;
                buGetAdmin.Enabled = false;
                adminPanel.Enabled = false;
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

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                byte[] data = Encoding.Unicode.GetBytes("0|" + tbMessage.Text);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), remotePort);
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
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), remotePort);
                listeningSocket.SendTo(data1, remotePoint);
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
                    string[] SplittedInfo = str.Split('|');
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
                                        MessageBox.Show(SplittedInfo[2], "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    case "1":
                                        DisconnectUser();
                                        MessageBox.Show(SplittedInfo[2], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            catch(Exception e)
                            {
                                DisconnectUser();
                                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case "2":
                            try
                            {
                                switch (SplittedInfo[1])
                                {
                                    case "0":
                                        isAdmin = true;
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
                                        this.Invoke(new Action(() => { this.BackColor = Color.White; }));
                                        foreach (var control in this.Controls)
                                        {
                                            if (control is Label label)
                                                label.ForeColor = Color.Black;
                                            else if (control is Panel panel)
                                                foreach (var cop in panel.Controls)
                                                    if (cop is Label lab)
                                                        lab.ForeColor = Color.Black;
                                        }
                                        break;
                                    case "Black":
                                        this.Invoke(new Action(() => { this.BackColor = Color.Black; }));
                                        foreach (var control in this.Controls)
                                        {
                                            if (control is Label label)
                                                label.ForeColor = Color.White;
                                            else if (control is Panel panel)
                                                foreach (var cop in panel.Controls)
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
        public static void SendMsg(string msg)
        {
            try
            {
                byte[] dataToSend = Encoding.Unicode.GetBytes(msg);
                EndPoint remotePoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), remotePort);
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

        private void buGetAdmin_Click(object sender, EventArgs e)
        {
            SendMsg("2|"+ tbUser.Text);
        }

        private void buBlack_Click(object sender, EventArgs e)
        {
            SendMsg("3|Black");
        }

        private void buWhite_Click(object sender, EventArgs e)
        {
            SendMsg("3|White");
        }

        private void buXO_Click(object sender, EventArgs e)
        {
            SendMsg("XO|Start");
            var fm = new fmXO(this);
            fm.Show();
        }
    }
}
