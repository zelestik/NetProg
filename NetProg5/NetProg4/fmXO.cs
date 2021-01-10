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
        readonly int startX = 10;
        readonly int startY = 10;
        readonly Button[,] field = new Button[3, 3];
        readonly Form1 MainForm;

        public fmXO(Form1 mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = new Button();
                    Controls.Add(field[i, j]);
                    field[i, j].Location = new Point
                        (
                            startX + i * field[i, j].Size.Width, 
                            startY + j * field[i, j].Size.Height
                        );
                    field[i, j].Click += FieldBtn_Click;
                    field[i, j].Name = i + "|" + j;
                }
            }

        }

        private void FieldBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                MainForm.SendMsg("XO|Play|" + btn.Name);
            }
        }

        public void AppendPropsBtn(
                int BtnX, 
                int BtnY,
                string PlayerSymbol,
                string enable
            ) 
        {
            Invoke(
                (MethodInvoker)delegate
                {
                    if (enable == "enabled")
                    {
                        foreach (Button btn in field)
                        {
                            if (btn.Text.Length == 0)
                            {
                                btn.Enabled = true;
                            }
                        }
                    }
                    else if (enable == "disabled")
                    {
                        foreach (Button btn in field)
                        {
                            if (btn.Text.Length == 0)
                            {
                                btn.Enabled = false;
                            }
                        }
                    }
                    field[BtnX, BtnY].Text = PlayerSymbol;
                    field[BtnX, BtnY].Enabled = false;
                }
            );
        }

        private void FmXO_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            HideWindow();
        }

        public void HideWindow()
        {
            Hide();
            foreach (Button btn in field)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            MainForm.SendMsg("XO|End");
        }
    }
}
