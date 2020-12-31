using ChatClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProg4
{
    public partial class fmXO : Form
    {
        int startX = 10;
        int startY = 10;
        string btnToSend = "";
        public string playerSymbol = "";
        Button[,] field = new Button[3, 3];
        Form1 mainForm;

        public fmXO(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    field[i, j] = new Button();
                    this.Controls.Add(field[i, j]);
                    field[i, j].Location = new Point(startX + i * field[i, j].Size.Width, startY + j * field[i, j].Size.Height);
                    field[i, j].Click += fieldBtn_Click;
                    field[i, j].Name = i + "|" + j;
                }
            }
        }

        private void fieldBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btnToSend = btn.Name;
                btn.Text = playerSymbol;
            }
        }

        public void ChangeFieldInstance()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j].Text == "")
                        field[i, j].Enabled = !field[i, j].Enabled;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mainForm.SendMsg("XO|Play|")ж
        }
    }
}
