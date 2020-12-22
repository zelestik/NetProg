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


namespace ChatClient
{
    public partial class Form1 : Form
    {
        static int remotePort = 8350; // порт для отправки сообщений
        static Socket listeningSocket;
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                Task listeningTask = new Task(Listen);
                listeningTask.Start();
                tbPort.Enabled = false;
                bConnDicon.Text = "Отключиться";
                isConnected = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                tbPort.Enabled = true;
                bConnDicon.Text = "Подключиться";
                isConnected = false;
                CloseSocket();
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
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
                byte[] data = Encoding.Unicode.GetBytes(tbMessage.Text);
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
                    lvMessages.Invoke(new Action(() => { lvMessages.Items.Add(builder.ToString()); })); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }
        // закрытие сокета
        private static void CloseSocket()
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
