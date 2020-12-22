namespace NetProg1
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
            this.cbIP = new System.Windows.Forms.CheckBox();
            this.cbDrives = new System.Windows.Forms.CheckBox();
            this.cbOS = new System.Windows.Forms.CheckBox();
            this.cbRAM = new System.Windows.Forms.CheckBox();
            this.cbAntivirus = new System.Windows.Forms.CheckBox();
            this.cbDomain = new System.Windows.Forms.CheckBox();
            this.cbPorts = new System.Windows.Forms.CheckBox();
            this.tbPorts = new System.Windows.Forms.TextBox();
            this.cbInDomain = new System.Windows.Forms.CheckBox();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbIP
            // 
            this.cbIP.AutoSize = true;
            this.cbIP.Location = new System.Drawing.Point(15, 12);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(50, 21);
            this.cbIP.TabIndex = 3;
            this.cbIP.Text = "IP: ";
            this.cbIP.UseVisualStyleBackColor = true;
            // 
            // cbDrives
            // 
            this.cbDrives.AutoSize = true;
            this.cbDrives.Location = new System.Drawing.Point(15, 41);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(78, 21);
            this.cbDrives.TabIndex = 4;
            this.cbDrives.Text = "Drives: ";
            this.cbDrives.UseVisualStyleBackColor = true;
            // 
            // cbOS
            // 
            this.cbOS.AutoSize = true;
            this.cbOS.Location = new System.Drawing.Point(15, 68);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(58, 21);
            this.cbOS.TabIndex = 5;
            this.cbOS.Text = "OS: ";
            this.cbOS.UseVisualStyleBackColor = true;
            // 
            // cbRAM
            // 
            this.cbRAM.AutoSize = true;
            this.cbRAM.Location = new System.Drawing.Point(15, 95);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(68, 21);
            this.cbRAM.TabIndex = 6;
            this.cbRAM.Text = "RAM: ";
            this.cbRAM.UseVisualStyleBackColor = true;
            // 
            // cbAntivirus
            // 
            this.cbAntivirus.AutoSize = true;
            this.cbAntivirus.Location = new System.Drawing.Point(15, 122);
            this.cbAntivirus.Name = "cbAntivirus";
            this.cbAntivirus.Size = new System.Drawing.Size(107, 21);
            this.cbAntivirus.TabIndex = 7;
            this.cbAntivirus.Text = "Антивирус: ";
            this.cbAntivirus.UseVisualStyleBackColor = true;
            // 
            // cbDomain
            // 
            this.cbDomain.AutoSize = true;
            this.cbDomain.Location = new System.Drawing.Point(15, 149);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(82, 21);
            this.cbDomain.TabIndex = 8;
            this.cbDomain.Text = "Домен: ";
            this.cbDomain.UseVisualStyleBackColor = true;
            // 
            // cbPorts
            // 
            this.cbPorts.AutoSize = true;
            this.cbPorts.Location = new System.Drawing.Point(15, 203);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(81, 21);
            this.cbPorts.TabIndex = 9;
            this.cbPorts.Text = "Порты: ";
            this.cbPorts.UseVisualStyleBackColor = true;
            // 
            // tbPorts
            // 
            this.tbPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPorts.Location = new System.Drawing.Point(86, 201);
            this.tbPorts.Multiline = true;
            this.tbPorts.Name = "tbPorts";
            this.tbPorts.ReadOnly = true;
            this.tbPorts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPorts.Size = new System.Drawing.Size(702, 23);
            this.tbPorts.TabIndex = 10;
            // 
            // cbInDomain
            // 
            this.cbInDomain.AutoSize = true;
            this.cbInDomain.Location = new System.Drawing.Point(15, 176);
            this.cbInDomain.Name = "cbInDomain";
            this.cbInDomain.Size = new System.Drawing.Size(140, 21);
            this.cbInDomain.TabIndex = 11;
            this.cbInDomain.Text = "В домен входит: ";
            this.cbInDomain.UseVisualStyleBackColor = true;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Location = new System.Drawing.Point(496, 415);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(145, 23);
            this.btnMakeReport.TabIndex = 12;
            this.btnMakeReport.Text = "Сделать отчёт";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(647, 414);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(141, 24);
            this.cbFormat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Формат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.cbInDomain);
            this.Controls.Add(this.tbPorts);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.cbDomain);
            this.Controls.Add(this.cbAntivirus);
            this.Controls.Add(this.cbRAM);
            this.Controls.Add(this.cbOS);
            this.Controls.Add(this.cbDrives);
            this.Controls.Add(this.cbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbIP;
        private System.Windows.Forms.CheckBox cbDrives;
        private System.Windows.Forms.CheckBox cbOS;
        private System.Windows.Forms.CheckBox cbRAM;
        private System.Windows.Forms.CheckBox cbAntivirus;
        private System.Windows.Forms.CheckBox cbDomain;
        private System.Windows.Forms.CheckBox cbPorts;
        private System.Windows.Forms.TextBox tbPorts;
        private System.Windows.Forms.CheckBox cbInDomain;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label1;
    }
}

