namespace NetProg3
{
    partial class Authorization
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
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.lgn = new System.Windows.Forms.TextBox();
            this.psswrd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(34, 43);
            this.login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(69, 28);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(34, 96);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 28);
            this.password.TabIndex = 1;
            this.password.Text = "Пароль";
            // 
            // lgn
            // 
            this.lgn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lgn.Location = new System.Drawing.Point(182, 35);
            this.lgn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(215, 34);
            this.lgn.TabIndex = 2;
            // 
            // psswrd
            // 
            this.psswrd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.psswrd.Location = new System.Drawing.Point(182, 94);
            this.psswrd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psswrd.Name = "psswrd";
            this.psswrd.Size = new System.Drawing.Size(215, 34);
            this.psswrd.TabIndex = 3;
            this.psswrd.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(40, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(456, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.psswrd);
            this.Controls.Add(this.lgn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox lgn;
        private System.Windows.Forms.TextBox psswrd;
        private System.Windows.Forms.Button button1;
    }
}

