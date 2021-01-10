
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.buGetAdmin = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.UsersCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buWhite = new System.Windows.Forms.Button();
            this.buBlack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GetSound = new System.Windows.Forms.Button();
            this.buXO = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.TextBox();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bConnDicon
            // 
            this.bConnDicon.Location = new System.Drawing.Point(323, 11);
            this.bConnDicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(783, 22);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // lvMessages
            // 
            this.lvMessages.HideSelection = false;
            this.lvMessages.Location = new System.Drawing.Point(12, 39);
            this.lvMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(783, 370);
            this.lvMessages.TabIndex = 4;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Порт:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(64, 12);
            this.tbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPort.Mask = "9999";
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 22);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "8351";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(217, 12);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 22);
            this.tbUser.TabIndex = 9;
            this.tbUser.Text = "Денис";
            // 
            // buGetAdmin
            // 
            this.buGetAdmin.Enabled = false;
            this.buGetAdmin.Location = new System.Drawing.Point(455, 11);
            this.buGetAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buGetAdmin.Name = "buGetAdmin";
            this.buGetAdmin.Size = new System.Drawing.Size(245, 23);
            this.buGetAdmin.TabIndex = 10;
            this.buGetAdmin.Text = "Получить права администратора";
            this.buGetAdmin.UseVisualStyleBackColor = true;
            this.buGetAdmin.Click += new System.EventHandler(this.BuGetAdmin_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.UsersCheckBox);
            this.adminPanel.Controls.Add(this.label4);
            this.adminPanel.Controls.Add(this.buWhite);
            this.adminPanel.Controls.Add(this.buBlack);
            this.adminPanel.Controls.Add(this.label3);
            this.adminPanel.Enabled = false;
            this.adminPanel.Location = new System.Drawing.Point(801, 39);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(271, 306);
            this.adminPanel.TabIndex = 12;
            // 
            // UsersCheckBox
            // 
            this.UsersCheckBox.FormattingEnabled = true;
            this.UsersCheckBox.Location = new System.Drawing.Point(7, 91);
            this.UsersCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsersCheckBox.Name = "UsersCheckBox";
            this.UsersCheckBox.Size = new System.Drawing.Size(259, 191);
            this.UsersCheckBox.TabIndex = 16;
            this.UsersCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.UsersCheckBox_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Админ панель";
            // 
            // buWhite
            // 
            this.buWhite.BackColor = System.Drawing.Color.White;
            this.buWhite.Location = new System.Drawing.Point(87, 60);
            this.buWhite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buWhite.Name = "buWhite";
            this.buWhite.Size = new System.Drawing.Size(75, 23);
            this.buWhite.TabIndex = 14;
            this.buWhite.UseVisualStyleBackColor = false;
            this.buWhite.Click += new System.EventHandler(this.BuWhite_Click);
            // 
            // buBlack
            // 
            this.buBlack.BackColor = System.Drawing.Color.Black;
            this.buBlack.Location = new System.Drawing.Point(5, 60);
            this.buBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buBlack.Name = "buBlack";
            this.buBlack.Size = new System.Drawing.Size(75, 23);
            this.buBlack.TabIndex = 13;
            this.buBlack.UseVisualStyleBackColor = false;
            this.buBlack.Click += new System.EventHandler(this.BuBlack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Цвет пользовательских окон";
            // 
            // GetSound
            // 
            this.GetSound.Location = new System.Drawing.Point(812, 412);
            this.GetSound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetSound.Name = "GetSound";
            this.GetSound.Size = new System.Drawing.Size(260, 28);
            this.GetSound.TabIndex = 16;
            this.GetSound.Text = "Мелодия";
            this.GetSound.UseVisualStyleBackColor = true;
            this.GetSound.Visible = false;
            this.GetSound.Click += new System.EventHandler(this.GetSound_Click);
            // 
            // buXO
            // 
            this.buXO.Enabled = false;
            this.buXO.Location = new System.Drawing.Point(707, 12);
            this.buXO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buXO.Name = "buXO";
            this.buXO.Size = new System.Drawing.Size(75, 23);
            this.buXO.TabIndex = 13;
            this.buXO.Text = "XO";
            this.buXO.UseVisualStyleBackColor = true;
            this.buXO.Click += new System.EventHandler(this.BuXO_Click);
            // 
            // test
            // 
            this.test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.test.Location = new System.Drawing.Point(812, 363);
            this.test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test.Multiline = true;
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Size = new System.Drawing.Size(256, 42);
            this.test.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.buXO);
            this.Controls.Add(this.GetSound);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.buGetAdmin);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bConnDicon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bConnDicon;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button buGetAdmin;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button buWhite;
        private System.Windows.Forms.Button buBlack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buXO;
        private System.Windows.Forms.Button GetSound;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.CheckedListBox UsersCheckBox;
    }
}

