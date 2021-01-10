using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetProg3
{
    public partial class UserPage : Form
    {
        Connection con = new Connection();
        string usr_id,username;
        public UserPage(string name,string id)
        {
            InitializeComponent();
            this.name.Text = "Страница пользователя " + name;
            username = name;
            usr_id = id;
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            LoadFiles();                        
        }

        private void rtrn_Click(object sender, EventArgs e)
        {
            SimpleAdmin page = new SimpleAdmin();
            page.FormClosed += SimpleAdmin_FormClosed;
            page.Show();
            this.Hide();
        }

        private void SimpleAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); //отображение 1-й формы после закрытия 2-й
            this.Close();
        }

        private void rtrn_MouseEnter(object sender, EventArgs e)
        {
            rtrn.ForeColor = Color.FromName("DeepSkyBlue");
        }

        private void rtrn_MouseLeave(object sender, EventArgs e)
        {
            rtrn.ForeColor = Color.FromName("Black");
        }

        private void files_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0;i< files.SelectedItems.Count;i++)
            {
                string answer = con.GetJSON($"files?id={files.SelectedItems[0].Tag}");
                files obj = JsonConvert.DeserializeObject<files>(answer.Substring(1, answer.Length - 2));
                string status = obj.status_file;
                if (files.SelectedItems.Count > 0)
                {
                    this.delete.Visible = true;
                    this.hide.Visible = true;
                    if (status=="private")
                    {
                        hide.Text = "Сделать публичным";
                        hide.Width = 165;
                        hf.Visible = true;
                    }
                    else
                    {
                        hide.Text = "Скрыть";
                        hide.Width = 135;
                        hf.Visible = false;
                    }

                }
                else
                {
                    this.delete.Visible = false;
                    this.hide.Visible = false;
                }
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Выдействительно хотите удалить этот файл?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"{files.SelectedItems[0].Text}");
                File.Delete(Path.Combine($"C:/xampp/htdocs/lb3/users/{username}",$"{files.SelectedItems[0].Text.Substring(2, files.SelectedItems[0].Text.Length-2)}"));
                con.DeleteJSON($"files/{files.SelectedItems[0].Tag}");
                //$"C:/xampp/htdocs/lb3/users/{}"
                LoadFiles();
            }
            
            
        }

        private void hide_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < files.SelectedItems.Count; i++)
            {
                string answer = con.GetJSON($"files?id={files.SelectedItems[i].Tag}");
                files obj = JsonConvert.DeserializeObject<files>(answer.Substring(1, answer.Length - 2));
                string status = obj.status_file;
                if (status == "private")
                {
                    DialogResult result = MessageBox.Show($"Выдействительно хотите изменить видимость файла?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        obj.status_file = "public";
                        hide.Text = "Скрыть";
                        hide.Width = 135;
                        hf.Visible = false;
                    }

                    else if (result == DialogResult.No)
                    {
                        break;
                    }

                }
                else if (status == "public")
                {
                    DialogResult result = MessageBox.Show($"Выдействительно хотите изменить видимость файла?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        obj.status_file = "private";
                        hide.Text = "Сделать публичным";
                        hide.Width = 165;
                        hf.Visible = true;
                    }
                    else if (result == DialogResult.No)
                    {
                        break;
                    }

                }
                string json = JsonConvert.SerializeObject(obj);
                con.PutJSON("files/" + obj.id, json);
                MessageBox.Show("Видимость файла была изменена");
                LoadFiles();
            }
        }

        private void LoadFiles()
        {
            int k = 1;
            string answer = con.GetJSON($"files?id_user={usr_id}");
            var obj = JsonConvert.DeserializeObject<List<files>>(answer);
            files.Items.Clear();
            foreach (var i in obj)
            {
                var item = new ListViewItem();
                item.Tag = i.id;
                item.Text = k + " " + i.name_file;
                files.Items.Add(item);
                k++;
            }


       
        }
    }
}
