namespace NetProg3
{
    partial class UserPage
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
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.files = new System.Windows.Forms.ListView();
            this.rtrn = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.hf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(7, 14);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 25);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список загруженных файлов";
            // 
            // files
            // 
            this.files.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.files.HideSelection = false;
            this.files.Location = new System.Drawing.Point(12, 105);
            this.files.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(1043, 441);
            this.files.TabIndex = 30;
            this.files.UseCompatibleStateImageBehavior = false;
            this.files.View = System.Windows.Forms.View.List;
            this.files.SelectedIndexChanged += new System.EventHandler(this.files_SelectedIndexChanged);
            // 
            // rtrn
            // 
            this.rtrn.AutoSize = true;
            this.rtrn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtrn.ForeColor = System.Drawing.Color.White;
            this.rtrn.Location = new System.Drawing.Point(865, 11);
            this.rtrn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rtrn.Name = "rtrn";
            this.rtrn.Size = new System.Drawing.Size(161, 28);
            this.rtrn.TabIndex = 31;
            this.rtrn.Text = "Вернуться назад";
            this.rtrn.Click += new System.EventHandler(this.rtrn_Click);
            this.rtrn.MouseEnter += new System.EventHandler(this.rtrn_MouseEnter);
            this.rtrn.MouseLeave += new System.EventHandler(this.rtrn_MouseLeave);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.delete.Location = new System.Drawing.Point(12, 559);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 38);
            this.delete.TabIndex = 32;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.White;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hide.Location = new System.Drawing.Point(200, 559);
            this.hide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(180, 38);
            this.hide.TabIndex = 33;
            this.hide.Text = "Скрыть";
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Visible = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // hf
            // 
            this.hf.AutoSize = true;
            this.hf.BackColor = System.Drawing.Color.Red;
            this.hf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hf.Location = new System.Drawing.Point(863, 559);
            this.hf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hf.Name = "hf";
            this.hf.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hf.Size = new System.Drawing.Size(186, 33);
            this.hf.TabIndex = 34;
            this.hf.Text = "Этот файл скрыт";
            this.hf.Visible = false;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 610);
            this.Controls.Add(this.hf);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.rtrn);
            this.Controls.Add(this.files);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView files;
        private System.Windows.Forms.Label rtrn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Label hf;
    }
}