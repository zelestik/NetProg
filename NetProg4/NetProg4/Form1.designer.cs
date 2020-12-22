
namespace ChatClient
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
            this.bConnDicon = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bConnDicon
            // 
            this.bConnDicon.Location = new System.Drawing.Point(670, 12);
            this.bConnDicon.Name = "bConnDicon";
            this.bConnDicon.Size = new System.Drawing.Size(125, 23);
            this.bConnDicon.TabIndex = 1;
            this.bConnDicon.Text = "Подключиться";
            this.bConnDicon.UseVisualStyleBackColor = true;
            this.bConnDicon.Click += new System.EventHandler(this.Button_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 416);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(783, 22);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // lvMessages
            // 
            this.lvMessages.HideSelection = false;
            this.lvMessages.Location = new System.Drawing.Point(12, 40);
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(783, 370);
            this.lvMessages.TabIndex = 4;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Порт:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(64, 12);
            this.tbPort.Mask = "9999";
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 22);
            this.tbPort.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bConnDicon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bConnDicon;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbPort;
    }
}

