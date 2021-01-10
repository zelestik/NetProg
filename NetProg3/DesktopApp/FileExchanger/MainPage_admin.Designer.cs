namespace NetProg3
{
    partial class MainPage_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Label();
            this.psswrd = new System.Windows.Forms.TextBox();
            this.lgn = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.unlock = new System.Windows.Forms.Button();
            this.toLock = new System.Windows.Forms.Button();
            this.active_admins = new System.Windows.Forms.ListView();
            this.Locked = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.RadioButton();
            this.csv = new System.Windows.Forms.RadioButton();
            this.doc = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.report = new System.Windows.Forms.GroupBox();
            this.doings = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.report.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(860, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 28);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выйти из аккаунта";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // psswrd
            // 
            this.psswrd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.psswrd.Location = new System.Drawing.Point(189, 101);
            this.psswrd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psswrd.Name = "psswrd";
            this.psswrd.Size = new System.Drawing.Size(215, 29);
            this.psswrd.TabIndex = 11;
            this.psswrd.UseSystemPasswordChar = true;
            // 
            // lgn
            // 
            this.lgn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lgn.Location = new System.Drawing.Point(189, 54);
            this.lgn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(215, 29);
            this.lgn.TabIndex = 10;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(89, 106);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 23);
            this.password.TabIndex = 9;
            this.password.Text = "Пароль";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(103, 59);
            this.login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(58, 23);
            this.login.TabIndex = 8;
            this.login.Text = "Логин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.lgn);
            this.groupBox1.Controls.Add(this.psswrd);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(576, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(475, 230);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового администратора в систему";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Add.Location = new System.Drawing.Point(93, 155);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(312, 37);
            this.Add.TabIndex = 12;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // unlock
            // 
            this.unlock.BackColor = System.Drawing.Color.White;
            this.unlock.FlatAppearance.BorderSize = 0;
            this.unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unlock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.unlock.Location = new System.Drawing.Point(16, 506);
            this.unlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unlock.Name = "unlock";
            this.unlock.Size = new System.Drawing.Size(255, 37);
            this.unlock.TabIndex = 13;
            this.unlock.Text = "Разблокировать";
            this.unlock.UseVisualStyleBackColor = false;
            this.unlock.Click += new System.EventHandler(this.unlock_Click);
            // 
            // toLock
            // 
            this.toLock.BackColor = System.Drawing.Color.White;
            this.toLock.FlatAppearance.BorderSize = 0;
            this.toLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toLock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toLock.Location = new System.Drawing.Point(299, 506);
            this.toLock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toLock.Name = "toLock";
            this.toLock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toLock.Size = new System.Drawing.Size(255, 37);
            this.toLock.TabIndex = 14;
            this.toLock.Text = "Заблокировать";
            this.toLock.UseVisualStyleBackColor = false;
            this.toLock.Click += new System.EventHandler(this.toLock_Click);
            // 
            // active_admins
            // 
            this.active_admins.CheckBoxes = true;
            this.active_admins.HideSelection = false;
            this.active_admins.Location = new System.Drawing.Point(299, 346);
            this.active_admins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.active_admins.Name = "active_admins";
            this.active_admins.Size = new System.Drawing.Size(253, 152);
            this.active_admins.TabIndex = 15;
            this.active_admins.UseCompatibleStateImageBehavior = false;
            this.active_admins.View = System.Windows.Forms.View.List;
            // 
            // Locked
            // 
            this.Locked.CheckBoxes = true;
            this.Locked.HideSelection = false;
            this.Locked.Location = new System.Drawing.Point(16, 346);
            this.Locked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Locked.Name = "Locked";
            this.Locked.Size = new System.Drawing.Size(253, 152);
            this.Locked.TabIndex = 16;
            this.Locked.UseCompatibleStateImageBehavior = false;
            this.Locked.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Заблокированные \r\nадмиистраторы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(353, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "Активные\r\nадминистраторы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вывести отчет в формате";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt.Location = new System.Drawing.Point(445, 27);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(62, 27);
            this.txt.TabIndex = 23;
            this.txt.TabStop = true;
            this.txt.Text = "*.txt";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.CheckedChanged += new System.EventHandler(this.txt_CheckedChanged);
            // 
            // csv
            // 
            this.csv.AutoSize = true;
            this.csv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csv.Location = new System.Drawing.Point(368, 27);
            this.csv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(65, 27);
            this.csv.TabIndex = 22;
            this.csv.TabStop = true;
            this.csv.Text = "*.csv";
            this.csv.UseVisualStyleBackColor = true;
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doc.Location = new System.Drawing.Point(285, 27);
            this.doc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(70, 27);
            this.doc.TabIndex = 21;
            this.doc.TabStop = true;
            this.doc.Text = "*.doc";
            this.doc.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(560, 21);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Save.Size = new System.Drawing.Size(181, 37);
            this.Save.TabIndex = 24;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.White;
            this.report.Controls.Add(this.Save);
            this.report.Controls.Add(this.label4);
            this.report.Controls.Add(this.txt);
            this.report.Controls.Add(this.csv);
            this.report.Controls.Add(this.doc);
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.ForeColor = System.Drawing.Color.Black;
            this.report.Location = new System.Drawing.Point(16, 558);
            this.report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.report.Size = new System.Drawing.Size(1035, 78);
            this.report.TabIndex = 25;
            this.report.TabStop = false;
            // 
            // doings
            // 
            this.doings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doings.FormattingEnabled = true;
            this.doings.ItemHeight = 21;
            this.doings.Location = new System.Drawing.Point(16, 57);
            this.doings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doings.Name = "doings";
            this.doings.Size = new System.Drawing.Size(1033, 193);
            this.doings.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(296, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Панель управления супер-администратора";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Locked);
            this.Controls.Add(this.active_admins);
            this.Controls.Add(this.toLock);
            this.Controls.Add(this.unlock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doings);
            this.Controls.Add(this.exit);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.report.ResumeLayout(false);
            this.report.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox psswrd;
        private System.Windows.Forms.TextBox lgn;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button unlock;
        private System.Windows.Forms.ListView active_admins;
        private System.Windows.Forms.ListView Locked;
        private System.Windows.Forms.Button toLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton csv;
        private System.Windows.Forms.RadioButton doc;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.GroupBox report;
        private System.Windows.Forms.ListBox doings;
        private System.Windows.Forms.Label label3;
    }
}