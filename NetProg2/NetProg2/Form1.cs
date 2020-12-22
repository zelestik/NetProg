using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetProg2.ServiceChat;
using System.Windows;
using System.Windows.Input;
using System.IO;

namespace ChatClient
{
    public partial class Form1 : Form, IServiceChatCallback
    {
        bool isConnected = false;
        ServiceChatClient client;
        int ID;
        public Form1()
        {
            InitializeComponent();
        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(tbUserName.Text);
                tbUserName.Enabled = false;
                bConnDicon.Text = "Отключиться";
                isConnected = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                tbUserName.Enabled = true;
                bConnDicon.Text = "Подключиться";
                isConnected = false;
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

        public void FileCallBack(byte[] fileToSend, string filename, string msg)
        {
            var item = lvMessages.Items.Add(msg);
            var mf = new MyFile(fileToSend, filename);
            item.Tag = mf;

        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(tbMessage.Text, ID);
                    tbMessage.Text = string.Empty;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectUser();
        }

        private void buSendFile_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                client.SendFile(File.ReadAllBytes(fd.FileName), fd.SafeFileName, ID);
        }

        private void lvMessages_MouseClick(object sender, MouseEventArgs e)
        {
            foreach(ListViewItem item in lvMessages.SelectedItems)
            {
                if(item.Tag is MyFile mf)
                {
                    var SFD = new FolderBrowserDialog();
                    if(SFD.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(SFD.SelectedPath + "/" + mf.filename, mf.file);
                    }
                }
            }
        }
    }

    public class MyFile
    {
        public byte[] file;
        public string filename;
        public MyFile(byte[] file, string filename)
        {
            this.file = file;
            this.filename = filename;
        }
    }
}
