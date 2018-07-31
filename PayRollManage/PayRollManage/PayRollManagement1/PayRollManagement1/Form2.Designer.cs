namespace PayRollManagement1
{
    partial class AdminForm
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
            this.f2btn1 = new System.Windows.Forms.Button();
            this.f2btn2 = new System.Windows.Forms.Button();
            this.f2btn3 = new System.Windows.Forms.Button();
            this.f2btn4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2btn5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // f2btn1
            // 
            this.f2btn1.Location = new System.Drawing.Point(112, 140);
            this.f2btn1.Name = "f2btn1";
            this.f2btn1.Size = new System.Drawing.Size(176, 32);
            this.f2btn1.TabIndex = 1;
            this.f2btn1.Text = "Attendance";
            this.f2btn1.UseVisualStyleBackColor = true;
            this.f2btn1.Click += new System.EventHandler(this.f2btn1_Click);
            // 
            // f2btn2
            // 
            this.f2btn2.Location = new System.Drawing.Point(422, 140);
            this.f2btn2.Name = "f2btn2";
            this.f2btn2.Size = new System.Drawing.Size(152, 32);
            this.f2btn2.TabIndex = 2;
            this.f2btn2.Text = "Salary";
            this.f2btn2.UseVisualStyleBackColor = true;
            this.f2btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // f2btn3
            // 
            this.f2btn3.Location = new System.Drawing.Point(88, 225);
            this.f2btn3.Name = "f2btn3";
            this.f2btn3.Size = new System.Drawing.Size(216, 35);
            this.f2btn3.TabIndex = 3;
            this.f2btn3.Text = "Employee Info";
            this.f2btn3.UseVisualStyleBackColor = true;
            this.f2btn3.Click += new System.EventHandler(this.f2btn3_Click);
            // 
            // f2btn4
            // 
            this.f2btn4.Location = new System.Drawing.Point(281, 318);
            this.f2btn4.Name = "f2btn4";
            this.f2btn4.Size = new System.Drawing.Size(75, 23);
            this.f2btn4.TabIndex = 4;
            this.f2btn4.Text = "Log Out";
            this.f2btn4.UseVisualStyleBackColor = true;
            this.f2btn4.Click += new System.EventHandler(this.f2btn4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEmailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.sendEmailToolStripMenuItem.Text = "Send E-mail";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // f2btn5
            // 
            this.f2btn5.Location = new System.Drawing.Point(422, 226);
            this.f2btn5.Name = "f2btn5";
            this.f2btn5.Size = new System.Drawing.Size(192, 34);
            this.f2btn5.TabIndex = 6;
            this.f2btn5.Text = "Leave ";
            this.f2btn5.UseVisualStyleBackColor = true;
            this.f2btn5.Click += new System.EventHandler(this.f2btn5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Development of Attendance and Payroll  System for Sailor Info Tech";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f2btn5);
            this.Controls.Add(this.f2btn4);
            this.Controls.Add(this.f2btn3);
            this.Controls.Add(this.f2btn2);
            this.Controls.Add(this.f2btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button f2btn1;
        private System.Windows.Forms.Button f2btn2;
        private System.Windows.Forms.Button f2btn3;
        private System.Windows.Forms.Button f2btn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.Button f2btn5;
        private System.Windows.Forms.Label label2;
    }
}