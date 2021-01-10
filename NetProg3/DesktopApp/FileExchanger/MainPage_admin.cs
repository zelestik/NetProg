using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace NetProg3
{
   
    public partial class MainPage_admin : Form
    {
        
        Connection con = new Connection();
        DateTime now = DateTime.Now;
        public MainPage_admin(List<string> activity)
        {
            InitializeComponent();
            for (int i=0;i< activity.Count;i++)
            {
                doings.Items.Add(activity[i]);
            }
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor =Color.FromName("DeepSkyBlue");
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.FromName("Black");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Authorization page = new Authorization();
            page.FormClosed += Authorization_FormClosed;
            page.Show();
            this.Hide();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); //отображение 1-й формы после закрытия 2-й
            this.Close();
        }

        private void MainPage_admin_Load(object sender, EventArgs e)
        {

            LoadAdmins();
            LoadLocked();
        }

        private void active_admins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string answer = con.GetJSON($"users?login={this.lgn.Text}");
           // MessageBox.Show(answer);
            if (answer != "[]")
            {
                MessageBox.Show("Аккаунт с таким именем уже зарегистрирован!");
            }
            else
            {
                admins admin = new admins(this.lgn.Text,this.psswrd.Text,2);
                string json = JsonConvert.SerializeObject(admin);
                con.PostJSON("users", json);
                doings.Items.Add($"{now} Пользователь {this.lgn.Text} был добавлен в систему");
                MessageBox.Show($"Пользователь {this.lgn.Text} добавлен в систему");
                LoadAdmins();
            }
        }

        private void LoadAdmins()
        {

            string answer = con.GetJSON($"users?role=2");
            var ch = this.active_admins;
            ch.Items.Clear();
            var obj = JsonConvert.DeserializeObject<List<admins>>(answer);
            foreach (var i in obj)
            {
                var item = new ListViewItem();
                item.Tag = i;
                item.Text = i.login;
                ch.Items.Add(item);
                
            }
        }

        private void LoadLocked()
        {

            string answer = con.GetJSON($"users?role=4");
            var ch = Locked;
            ch.Items.Clear();
            var obj = JsonConvert.DeserializeObject<List<admins>>(answer);
            foreach (var i in obj)
            {
                var item = new ListViewItem();
                item.Tag = i;
                item.Text = i.login;
                ch.Items.Add(item);
            }
        }


        private void toLock_Click(object sender, EventArgs e)
        {
                foreach (var item in active_admins.CheckedItems)
                {
                    if (item is ListViewItem lv)
                    {
                        if (lv.Tag is admins admns)
                        {
                            admns.role = 4;
                            string json = JsonConvert.SerializeObject(admns);
                            con.PutJSON("users/" + admns.id, json);
                        doings.Items.Add($"{now} Пользователь {admns.login} был заблокирован");
                    }
                    }
                   
                }
            MessageBox.Show("Выбранные пользователи были заблокированы");
            LoadAdmins();
            LoadLocked();
        }

        private void unlock_Click(object sender, EventArgs e)
        {
            foreach (var item in Locked.CheckedItems)
            {
                if (item is ListViewItem lv)
                {
                    if (lv.Tag is admins admns)
                    {
                        admns.role = 2;
                        string json = JsonConvert.SerializeObject(admns);
                        con.PutJSON("users/" + admns.id, json);
                        doings.Items.Add($"{now} Пользователь {admns.login} был разблокирован");
                    }
                }

            }
            MessageBox.Show("Выбранные пользователи были разблокированы");
            LoadAdmins();
            LoadLocked();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string text = "",date,locked="",active="",doings="";
            DateTime now = DateTime.Now;
            date = now.ToString("D");
            for(int i=0;i<active_admins.Items.Count;i++)
            {
                active = active + active_admins.Items[i].Text+"\n";
            }

            for (int i = 0; i < Locked.Items.Count; i++)
            {
                locked = locked + Locked.Items[i].Text + "\n";
            }

            foreach(var item in this.doings.Items)
            {
                doings = doings + item + "\n";
            }

            text = date + "\n" + "\n" + "Активные администраторы:" + "\n" + "\n" + active + "\n" + "\n" + "Заблокированные администраторы:" + "\n" + "\n" + locked + "\n";
            if (doings != "") text = text + "Последние действия:" + "\n" + "\n" + doings;
            foreach (Control control in report.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rb = control as RadioButton;
                    if (rb.Checked)
                    {
                        switch (rb.Text)
                        {
                            case "*.doc":
                                SFD.Filter = "документы Word|*.doc";
                                break;
                            case "*.csv":
                                SFD.Filter = "CSV UTF-8 (разделитель - запятая)|*.csv";
                                break;
                            case "*.txt":
                                SFD.Filter = "Текстовые файлы | *.txt";
                                break;

                        }
                    }
                }
            }
            if (SFD.ShowDialog() == DialogResult.OK)
            {

                string filename = SFD.FileName;
                System.IO.File.WriteAllText(filename, text, Encoding.UTF8);
                MessageBox.Show("Ваш файл сохранен!");
            }
        }

    }
}
