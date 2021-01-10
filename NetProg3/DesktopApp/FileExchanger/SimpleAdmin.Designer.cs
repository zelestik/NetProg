namespace NetProg3
{
    partial class SimpleAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.ListView();
            this.lck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unlock = new System.Windows.Forms.Button();
            this.locked = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(316, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Панель управления администратора";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(860, 25);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 28);
            this.exit.TabIndex = 27;
            this.exit.Text = "Выйти из аккаунта";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // users
            // 
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users.HideSelection = false;
            this.users.Location = new System.Drawing.Point(16, 102);
            this.users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(518, 214);
            this.users.TabIndex = 29;
            this.users.UseCompatibleStateImageBehavior = false;
            this.users.View = System.Windows.Forms.View.List;
            this.users.SelectedIndexChanged += new System.EventHandler(this.users_SelectedIndexChanged);
            this.users.DoubleClick += new System.EventHandler(this.users_DoubleClick);
            // 
            // lck
            // 
            this.lck.BackColor = System.Drawing.Color.White;
            this.lck.FlatAppearance.BorderSize = 0;
            this.lck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lck.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lck.Location = new System.Drawing.Point(16, 326);
            this.lck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lck.Name = "lck";
            this.lck.Size = new System.Drawing.Size(255, 38);
            this.lck.TabIndex = 34;
            this.lck.Text = "Заблокировать";
            this.lck.UseVisualStyleBackColor = false;
            this.lck.Visible = false;
            this.lck.Click += new System.EventHandler(this.lck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Активные пользователи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unlock
            // 
            this.unlock.BackColor = System.Drawing.Color.White;
            this.unlock.FlatAppearance.BorderSize = 0;
            this.unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unlock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.unlock.Location = new System.Drawing.Point(542, 324);
            this.unlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unlock.Name = "unlock";
            this.unlock.Size = new System.Drawing.Size(255, 38);
            this.unlock.TabIndex = 37;
            this.unlock.Text = "Разблокировать";
            this.unlock.UseVisualStyleBackColor = false;
            this.unlock.Click += new System.EventHandler(this.unlock_Click);
            // 
            // locked
            // 
            this.locked.CheckBoxes = true;
            this.locked.HideSelection = false;
            this.locked.Location = new System.Drawing.Point(542, 102);
            this.locked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locked.Name = "locked";
            this.locked.Size = new System.Drawing.Size(498, 214);
            this.locked.TabIndex = 38;
            this.locked.UseCompatibleStateImageBehavior = false;
            this.locked.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(537, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Заблокированные пользователи";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locked);
            this.Controls.Add(this.unlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lck);
            this.Controls.Add(this.users);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SimpleAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleAdmin";
            this.Load += new System.EventHandler(this.SimpleAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.ListView users;
        private System.Windows.Forms.Button lck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button unlock;
        private System.Windows.Forms.ListView locked;
        private System.Windows.Forms.Label label2;
    }
}