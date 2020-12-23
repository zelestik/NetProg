
namespace NetProg6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSumToChange = new System.Windows.Forms.MaskedTextBox();
            this.laBalance = new System.Windows.Forms.Label();
            this.tbCardNum = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buAddCard = new System.Windows.Forms.Button();
            this.laSum = new System.Windows.Forms.Label();
            this.buGetBalance = new System.Windows.Forms.Button();
            this.buAddMoney = new System.Windows.Forms.Button();
            this.buMinusMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSumToChange
            // 
            this.tbSumToChange.Location = new System.Drawing.Point(230, 40);
            this.tbSumToChange.Mask = "99999999";
            this.tbSumToChange.Name = "tbSumToChange";
            this.tbSumToChange.Size = new System.Drawing.Size(100, 22);
            this.tbSumToChange.TabIndex = 2;
            // 
            // laBalance
            // 
            this.laBalance.AutoSize = true;
            this.laBalance.Location = new System.Drawing.Point(223, 12);
            this.laBalance.Name = "laBalance";
            this.laBalance.Size = new System.Drawing.Size(64, 17);
            this.laBalance.TabIndex = 5;
            this.laBalance.Text = "Баланс: ";
            // 
            // tbCardNum
            // 
            this.tbCardNum.Location = new System.Drawing.Point(113, 9);
            this.tbCardNum.Mask = "999999999999";
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(100, 22);
            this.tbCardNum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер карты";
            // 
            // buAddCard
            // 
            this.buAddCard.Location = new System.Drawing.Point(15, 82);
            this.buAddCard.Name = "buAddCard";
            this.buAddCard.Size = new System.Drawing.Size(133, 23);
            this.buAddCard.TabIndex = 9;
            this.buAddCard.Text = "Добавить карту";
            this.buAddCard.UseVisualStyleBackColor = true;
            this.buAddCard.Click += new System.EventHandler(this.buAddCard_Click);
            // 
            // laSum
            // 
            this.laSum.AutoSize = true;
            this.laSum.Location = new System.Drawing.Point(13, 43);
            this.laSum.Name = "laSum";
            this.laSum.Size = new System.Drawing.Size(211, 17);
            this.laSum.TabIndex = 10;
            this.laSum.Text = "Сумма для добавления/снятия";
            // 
            // buGetBalance
            // 
            this.buGetBalance.Location = new System.Drawing.Point(154, 82);
            this.buGetBalance.Name = "buGetBalance";
            this.buGetBalance.Size = new System.Drawing.Size(125, 23);
            this.buGetBalance.TabIndex = 11;
            this.buGetBalance.Text = "Узнать баланс";
            this.buGetBalance.UseVisualStyleBackColor = true;
            this.buGetBalance.Click += new System.EventHandler(this.buGetBalance_Click);
            // 
            // buAddMoney
            // 
            this.buAddMoney.Location = new System.Drawing.Point(285, 82);
            this.buAddMoney.Name = "buAddMoney";
            this.buAddMoney.Size = new System.Drawing.Size(94, 23);
            this.buAddMoney.TabIndex = 12;
            this.buAddMoney.Text = "Добавить";
            this.buAddMoney.UseVisualStyleBackColor = true;
            this.buAddMoney.Click += new System.EventHandler(this.buAddMoney_Click);
            // 
            // buMinusMoney
            // 
            this.buMinusMoney.Location = new System.Drawing.Point(385, 82);
            this.buMinusMoney.Name = "buMinusMoney";
            this.buMinusMoney.Size = new System.Drawing.Size(94, 23);
            this.buMinusMoney.TabIndex = 13;
            this.buMinusMoney.Text = "Снять";
            this.buMinusMoney.UseVisualStyleBackColor = true;
            this.buMinusMoney.Click += new System.EventHandler(this.buMinusMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 117);
            this.Controls.Add(this.buMinusMoney);
            this.Controls.Add(this.buAddMoney);
            this.Controls.Add(this.buGetBalance);
            this.Controls.Add(this.laSum);
            this.Controls.Add(this.buAddCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCardNum);
            this.Controls.Add(this.laBalance);
            this.Controls.Add(this.tbSumToChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox tbSumToChange;
        private System.Windows.Forms.Label laBalance;
        private System.Windows.Forms.MaskedTextBox tbCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buAddCard;
        private System.Windows.Forms.Label laSum;
        private System.Windows.Forms.Button buGetBalance;
        private System.Windows.Forms.Button buAddMoney;
        private System.Windows.Forms.Button buMinusMoney;
    }
}

