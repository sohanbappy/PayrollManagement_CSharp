namespace PayRollManagement1
{
    partial class mailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.f9btn1 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.GroupBox();
            this.f9tb9 = new System.Windows.Forms.TextBox();
            this.f9tb8 = new System.Windows.Forms.TextBox();
            this.f9tb7 = new System.Windows.Forms.TextBox();
            this.f9tb6 = new System.Windows.Forms.TextBox();
            this.sslck = new System.Windows.Forms.CheckBox();
            this.f9btn2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.f9btn3 = new System.Windows.Forms.Button();
            this.f9tb5 = new System.Windows.Forms.TextBox();
            this.f9tb1 = new System.Windows.Forms.TextBox();
            this.f9tb2 = new System.Windows.Forms.TextBox();
            this.f9tb3 = new System.Windows.Forms.TextBox();
            this.f9tb4 = new System.Windows.Forms.TextBox();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Attachment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "SMTP";
            // 
            // f9btn1
            // 
            this.f9btn1.Location = new System.Drawing.Point(466, 23);
            this.f9btn1.Name = "f9btn1";
            this.f9btn1.Size = new System.Drawing.Size(75, 86);
            this.f9btn1.TabIndex = 10;
            this.f9btn1.Text = "Send";
            this.f9btn1.UseVisualStyleBackColor = true;
            this.f9btn1.Click += new System.EventHandler(this.f9btn1_Click);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.f9tb9);
            this.settings.Controls.Add(this.f9tb8);
            this.settings.Controls.Add(this.f9tb7);
            this.settings.Controls.Add(this.f9tb6);
            this.settings.Controls.Add(this.sslck);
            this.settings.Controls.Add(this.f9btn1);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.label10);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.label8);
            this.settings.Location = new System.Drawing.Point(230, 344);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(578, 156);
            this.settings.TabIndex = 11;
            this.settings.TabStop = false;
            this.settings.Text = "Settings";
            // 
            // f9tb9
            // 
            this.f9tb9.Location = new System.Drawing.Point(295, 89);
            this.f9tb9.Name = "f9tb9";
            this.f9tb9.ReadOnly = true;
            this.f9tb9.Size = new System.Drawing.Size(135, 20);
            this.f9tb9.TabIndex = 15;
            this.f9tb9.Text = "smtp.gmail.com";
            // 
            // f9tb8
            // 
            this.f9tb8.Location = new System.Drawing.Point(135, 86);
            this.f9tb8.Name = "f9tb8";
            this.f9tb8.ReadOnly = true;
            this.f9tb8.Size = new System.Drawing.Size(100, 20);
            this.f9tb8.TabIndex = 14;
            this.f9tb8.Text = "587";
            // 
            // f9tb7
            // 
            this.f9tb7.Location = new System.Drawing.Point(135, 55);
            this.f9tb7.Name = "f9tb7";
            this.f9tb7.Size = new System.Drawing.Size(138, 20);
            this.f9tb7.TabIndex = 13;
            // 
            // f9tb6
            // 
            this.f9tb6.Location = new System.Drawing.Point(135, 23);
            this.f9tb6.Name = "f9tb6";
            this.f9tb6.Size = new System.Drawing.Size(138, 20);
            this.f9tb6.TabIndex = 12;
            // 
            // sslck
            // 
            this.sslck.AutoSize = true;
            this.sslck.Location = new System.Drawing.Point(314, 25);
            this.sslck.Name = "sslck";
            this.sslck.Size = new System.Drawing.Size(46, 17);
            this.sslck.TabIndex = 11;
            this.sslck.Text = "SSL";
            this.sslck.UseVisualStyleBackColor = true;
            this.sslck.CheckedChanged += new System.EventHandler(this.sslck_CheckedChanged);
            // 
            // f9btn2
            // 
            this.f9btn2.Location = new System.Drawing.Point(57, 390);
            this.f9btn2.Name = "f9btn2";
            this.f9btn2.Size = new System.Drawing.Size(146, 53);
            this.f9btn2.TabIndex = 12;
            this.f9btn2.Text = "Exit";
            this.f9btn2.UseVisualStyleBackColor = true;
            this.f9btn2.Click += new System.EventHandler(this.f9btn2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // f9btn3
            // 
            this.f9btn3.Location = new System.Drawing.Point(515, 289);
            this.f9btn3.Name = "f9btn3";
            this.f9btn3.Size = new System.Drawing.Size(75, 23);
            this.f9btn3.TabIndex = 13;
            this.f9btn3.Text = "Open";
            this.f9btn3.UseVisualStyleBackColor = true;
            this.f9btn3.Click += new System.EventHandler(this.f9btn3_Click);
            // 
            // f9tb5
            // 
            this.f9tb5.Location = new System.Drawing.Point(230, 289);
            this.f9tb5.Name = "f9tb5";
            this.f9tb5.Size = new System.Drawing.Size(273, 20);
            this.f9tb5.TabIndex = 14;
            // 
            // f9tb1
            // 
            this.f9tb1.Location = new System.Drawing.Point(230, 54);
            this.f9tb1.Name = "f9tb1";
            this.f9tb1.Size = new System.Drawing.Size(360, 20);
            this.f9tb1.TabIndex = 15;
            // 
            // f9tb2
            // 
            this.f9tb2.Location = new System.Drawing.Point(230, 96);
            this.f9tb2.Name = "f9tb2";
            this.f9tb2.Size = new System.Drawing.Size(360, 20);
            this.f9tb2.TabIndex = 16;
            // 
            // f9tb3
            // 
            this.f9tb3.Location = new System.Drawing.Point(230, 141);
            this.f9tb3.Name = "f9tb3";
            this.f9tb3.Size = new System.Drawing.Size(360, 20);
            this.f9tb3.TabIndex = 17;
            // 
            // f9tb4
            // 
            this.f9tb4.Location = new System.Drawing.Point(230, 175);
            this.f9tb4.Multiline = true;
            this.f9tb4.Name = "f9tb4";
            this.f9tb4.Size = new System.Drawing.Size(360, 90);
            this.f9tb4.TabIndex = 18;
            // 
            // mailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 549);
            this.Controls.Add(this.f9tb4);
            this.Controls.Add(this.f9tb3);
            this.Controls.Add(this.f9tb2);
            this.Controls.Add(this.f9tb1);
            this.Controls.Add(this.f9tb5);
            this.Controls.Add(this.f9btn3);
            this.Controls.Add(this.f9btn2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mailForm";
            this.Text = "E-mail";
            this.Load += new System.EventHandler(this.mailForm_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button f9btn1;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.Button f9btn2;
        private System.Windows.Forms.CheckBox sslck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button f9btn3;
        private System.Windows.Forms.TextBox f9tb5;
        private System.Windows.Forms.TextBox f9tb6;
        private System.Windows.Forms.TextBox f9tb1;
        private System.Windows.Forms.TextBox f9tb2;
        private System.Windows.Forms.TextBox f9tb3;
        private System.Windows.Forms.TextBox f9tb4;
        private System.Windows.Forms.TextBox f9tb9;
        private System.Windows.Forms.TextBox f9tb8;
        private System.Windows.Forms.TextBox f9tb7;
    }
}