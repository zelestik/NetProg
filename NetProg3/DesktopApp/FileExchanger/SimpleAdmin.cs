using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetProg3
{
    public partial class SimpleAdmin : Form
    {
        string name = "";
        string id;
        Connection con = new Connection();
        Authorization page;

        public SimpleAdmin()
        {
            InitializeComponent();
        }

        public SimpleAdmin(Authorization p)
        {
            InitializeComponent();

            page = p;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.FromName("DeepSkyBlue");
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.FromName("Black");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Authorization page = new Authorization();
            //page.FormClosed += Authorization_FormClosed;
            //page.Show();
            page.Show();
            this.Hide();
        }
        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); //отображение 1-й формы после закрытия 2-й
            this.Close();
        }

        private void SimpleAdmin_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadLocked();
        }

        

        private void users_DoubleClick(object sender, EventArgs e)
        {
            name = users.SelectedItems[0].Text;
            id = $"{users.SelectedItems[0].Tag}";
            string answer = con.GetJSON($"files?id_user={id}");
            if (answer == "[]")
            {
                MessageBox.Show("Пользователь не загрузил свои файлы");
            }
            else
            {
                UserPage page = new UserPage(name, id);
                page.FormClosed += page_FormClosed;
                page.Show();
                this.Hide();
            }
            
            
        }

        private void page_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); //отображение 1-й формы после закрытия 2-й
            this.Close();
        }

        private void unlock_Click(object sender, EventArgs e)
        {
            for (int i=0;i< locked.CheckedItems.Count;i++)
            {
                string answer = con.GetJSON($"users?id={locked.CheckedItems[i].Tag}");
                admins obj = JsonConvert.DeserializeObject<admins>(answer.Substring(1, answer.Length - 2));
                obj.role = 3;
                string json = JsonConvert.SerializeObject(obj);
                con.PutJSON("users/" + obj.id, json);
             
            }
            MessageBox.Show("Выбранные пользователи были разблокированы");
            LoadUsers();
            LoadLocked();

        }

        private void lck_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < users.SelectedItems.Count; i++)
            {
                
                string answer = con.GetJSON($"users?id={users.SelectedItems[i].Tag}");

                admins obj = JsonConvert.DeserializeObject<admins>(answer.Substring(1, answer.Length - 2));
                DialogResult result = MessageBox.Show( $"Заблокировать пользователя {obj.login}?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    obj.role = 5;
                    string json = JsonConvert.SerializeObject(obj);
                    con.PutJSON("users/" + obj.id, json);
                    LoadUsers();
                    LoadLocked();
                    MessageBox.Show($"Пользователь {obj.login} был заблокирован");
                    lck.Visible = false;
                }
                else if (result == DialogResult.No)
                {
                    lck.Visible = false;
                    break;
                }


            }
            
        }

        private void LoadUsers()
        {
            string answer = con.GetJSON($"users?role=3");
            users.Items.Clear();
            var obj = JsonConvert.DeserializeObject<List<admins>>(answer);
            foreach (var i in obj)
            {
                var item = new ListViewItem();
                item.Tag = i.id;
                item.Text = i.login;
                users.Items.Add(item);

            }
        }

        private void LoadLocked()
        {
            string answer = con.GetJSON($"users?role=5");
            var ch = locked;
            ch.Items.Clear();
            var obj = JsonConvert.DeserializeObject<List<admins>>(answer);
            foreach (var i in obj)
            {
                var item = new ListViewItem();
                item.Tag = i.id;
                item.Text = i.login;
                ch.Items.Add(item);
            }
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < users.SelectedItems.Count; i++)
            {
                if (users.SelectedItems.Count > 0)
                {
                    this.lck.Visible = true;
                }
                else
                {
                    this.lck.Visible = false;
                }
            }
        }
    }
}
