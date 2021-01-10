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
    public partial class Authorization : Form
    {
        List<string> activity=new List<string>();
       

        class roles
        {
            public roles( string v2)
            {
                this.name = v2;
            }
            
            public string name { get; set; }
        }

        class users
        {
            public int id { get; set; }

        }
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (lgn.Text == "" || psswrd.Text == "") MessageBox.Show("Поля логин и пароль не должны быть пустыми!");
             else {
                 bool  r=UserCheck(lgn.Text,psswrd.Text);
                 if (r)
                 {
                    int o=CategoryCheck(lgn.Text, psswrd.Text);
                    if (o == 1)
                    {
                        {
                            MainPage_admin page = new MainPage_admin(activity);
                            page.FormClosed += page_FormClosed;
                            page.Show();
                            this.Hide();
                            
                        }
                                                
                    }
                    else if (o==2)
                    {
                        DateTime now = DateTime.Now;
                        string s = "";
                        s = now.ToString() + $" пользователь под логином {this.lgn.Text} выполнил вход в систему";
                        activity.Add(s);
                        //MainPage_admin data = new MainPage_admin(activity);
                        SimpleAdmin page = new SimpleAdmin(this);
                        page.FormClosed += page_FormClosed;
                        page.Show();
                        this.Hide();
                    }
                    else if (o == 4)
                    {
                        MessageBox.Show("Ваш аккаунт был заблокирован, за разблокировкой обращайтесь к супер-администратору");
                    }
                    else if (o == 3)
                    {
                        MessageBox.Show("Данной категорий пользователей доступ запрещен");
                    }
                 }
                 else MessageBox.Show("Пользователь не найден в системе! Возможно ваши данные для авторизациии введены неверно");
             }
             
        }

        public bool UserCheck(string login, string password)
        {
            Connection con = new Connection();
            string answer = con.GetJSON($"users?login={login}&password={password}");
            if (answer == "[]") return false;
            else return true;
        }

        public int CategoryCheck(string login, string password)
        {
            Connection con = new Connection();
            string answer = con.GetJSON($"users?login={login}&password={password}");

            admins obj = JsonConvert.DeserializeObject<admins>(answer.Substring(1, answer.Length - 2));
            return obj.role;
        }

        private void page_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); //отображение 1-й формы после закрытия 2-й
            this.Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
