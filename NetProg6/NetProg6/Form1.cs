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

        private void buGetBalance_Click(object sender, EventArgs e)
        {
            if (tbCardNum.Text != "")
            {
                long balance = service.GetBalance(long.Parse(tbCardNum.Text));
                if (balance != long.MinValue)
                    laBalance.Text = "Баланс: " + balance.ToString();
                else
                    MessageBox.Show("Возможно карта не добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Проверьте корректность ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buAddCard_Click(object sender, EventArgs e)
        {
            if (tbCardNum.Text != "")
                if (service.AddCard(long.Parse(tbCardNum.Text)))
                    MessageBox.Show("Карта добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ошибка добавления карты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Проверьте корректность ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buAddMoney_Click(object sender, EventArgs e)
        {
            if (tbCardNum.Text != "" && tbSumToChange.Text != "")
            {
                long balance = service.ChangeCardBalance(long.Parse(tbCardNum.Text), long.Parse(tbSumToChange.Text));
                if (balance != long.MinValue)
                    laBalance.Text = "Баланс: " + balance.ToString();
                else
                    MessageBox.Show("Возможно карта не добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Проверьте корректность ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buMinusMoney_Click(object sender, EventArgs e)
        {
            if (tbCardNum.Text != "" && tbSumToChange.Text != "")
            {
                long balance = service.ChangeCardBalance(long.Parse(tbCardNum.Text), -long.Parse(tbSumToChange.Text));
                if (balance != long.MinValue)
                    laBalance.Text = "Баланс: " + balance.ToString();
                else
                    MessageBox.Show("Возможно карта не добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Проверьте корректность ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
