
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.bConnDicon = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.buSendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(12, 12);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(652, 22);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "Имя";
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
            this.tbMessage.Size = new System.Drawing.Size(608, 22);
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
            this.lvMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMessages_MouseClick);
            // 
            // buSendFile
            // 
            this.buSendFile.Location = new System.Drawing.Point(626, 416);
            this.buSendFile.Name = "buSendFile";
            this.buSendFile.Size = new System.Drawing.Size(169, 23);
            this.buSendFile.TabIndex = 5;
            this.buSendFile.Text = "Отправить файл";
            this.buSendFile.UseVisualStyleBackColor = true;
            this.buSendFile.Click += new System.EventHandler(this.buSendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buSendFile);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bConnDicon);
            this.Controls.Add(this.tbUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button bConnDicon;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.Button buSendFile;
    }
}

