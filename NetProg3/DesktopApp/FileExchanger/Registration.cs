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
    public partial class Registration : Form
    {
        string url_admins = "http://localhost:3000/admins";
        string url_roles = "http://localhost:3000/roles";
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Authorization rtrn = new Authorization();
            rtrn.FormClosed += rtrn_FormClosed;
            rtrn.Show();
            this.Hide();
        }

        private void rtrn_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); //отображение 1-й формы после закрытия 2-й
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
