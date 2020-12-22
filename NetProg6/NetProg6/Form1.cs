using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetProg6.Server;

namespace NetProg6
{
    public partial class Form1 : Form
    {
        ServiceClient service;
        public Form1()
        {
            InitializeComponent();
            try
            {
                service = new ServiceClient();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void buSend_Click(object sender, EventArgs e)
        {
            service.HelloUser(tbMessage.Text);
        }

        private void buCalc_Click(object sender, EventArgs e)
        {
            laResult.Text = "=" + service.Summator(Int32.Parse(tbNum1.Text), Int32.Parse(tbNum2.Text)).ToString();
        }
    }
}
