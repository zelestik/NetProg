
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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.buSend = new System.Windows.Forms.Button();
            this.tbNum1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.MaskedTextBox();
            this.laResult = new System.Windows.Forms.Label();
            this.buCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 12);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(263, 22);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.Text = "Как Вас зовут?";
            // 
            // buSend
            // 
            this.buSend.Location = new System.Drawing.Point(281, 12);
            this.buSend.Name = "buSend";
            this.buSend.Size = new System.Drawing.Size(146, 23);
            this.buSend.TabIndex = 1;
            this.buSend.Text = "Отправить";
            this.buSend.UseVisualStyleBackColor = true;
            this.buSend.Click += new System.EventHandler(this.buSend_Click);
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(12, 54);
            this.tbNum1.Mask = "999";
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 22);
            this.tbNum1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(140, 54);
            this.tbNum2.Mask = "999";
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 22);
            this.tbNum2.TabIndex = 4;
            // 
            // laResult
            // 
            this.laResult.AutoSize = true;
            this.laResult.Location = new System.Drawing.Point(247, 57);
            this.laResult.Name = "laResult";
            this.laResult.Size = new System.Drawing.Size(16, 17);
            this.laResult.TabIndex = 5;
            this.laResult.Text = "=";
            // 
            // buCalc
            // 
            this.buCalc.Location = new System.Drawing.Point(346, 53);
            this.buCalc.Name = "buCalc";
            this.buCalc.Size = new System.Drawing.Size(90, 23);
            this.buCalc.TabIndex = 6;
            this.buCalc.Text = "Посчитать";
            this.buCalc.UseVisualStyleBackColor = true;
            this.buCalc.Click += new System.EventHandler(this.buCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 117);
            this.Controls.Add(this.buCalc);
            this.Controls.Add(this.laResult);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.buSend);
            this.Controls.Add(this.tbMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button buSend;
        private System.Windows.Forms.MaskedTextBox tbNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbNum2;
        private System.Windows.Forms.Label laResult;
        private System.Windows.Forms.Button buCalc;
    }
}

