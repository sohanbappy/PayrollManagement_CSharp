namespace PayRollManagement1
{
    partial class LoginForm
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
            this.f1btn1 = new System.Windows.Forms.Button();
            this.f1btn2 = new System.Windows.Forms.Button();
            this.f1tb1 = new System.Windows.Forms.TextBox();
            this.f1tb2 = new System.Windows.Forms.TextBox();
            this.f1cb1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // f1btn1
            // 
            this.f1btn1.Location = new System.Drawing.Point(266, 261);
            this.f1btn1.Name = "f1btn1";
            this.f1btn1.Size = new System.Drawing.Size(75, 23);
            this.f1btn1.TabIndex = 3;
            this.f1btn1.Text = "Login";
            this.f1btn1.UseVisualStyleBackColor = true;
            this.f1btn1.Click += new System.EventHandler(this.f1btn1_Click);
            // 
            // f1btn2
            // 
            this.f1btn2.Location = new System.Drawing.Point(404, 261);
            this.f1btn2.Name = "f1btn2";
            this.f1btn2.Size = new System.Drawing.Size(75, 23);
            this.f1btn2.TabIndex = 4;
            this.f1btn2.Text = "Clear";
            this.f1btn2.UseVisualStyleBackColor = true;
            this.f1btn2.Click += new System.EventHandler(this.f1btn2_Click);
            // 
            // f1tb1
            // 
            this.f1tb1.Location = new System.Drawing.Point(304, 91);
            this.f1tb1.Name = "f1tb1";
            this.f1tb1.Size = new System.Drawing.Size(100, 20);
            this.f1tb1.TabIndex = 5;
            // 
            // f1tb2
            // 
            this.f1tb2.Location = new System.Drawing.Point(304, 144);
            this.f1tb2.Name = "f1tb2";
            this.f1tb2.PasswordChar = '*';
            this.f1tb2.Size = new System.Drawing.Size(100, 20);
            this.f1tb2.TabIndex = 6;
            // 
            // f1cb1
            // 
            this.f1cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f1cb1.FormattingEnabled = true;
            this.f1cb1.Items.AddRange(new object[] {
            "------------",
            "Admin",
            "Employee"});
            this.f1cb1.Location = new System.Drawing.Point(304, 193);
            this.f1cb1.Name = "f1cb1";
            this.f1cb1.Size = new System.Drawing.Size(100, 21);
            this.f1cb1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 369);
            this.Controls.Add(this.f1cb1);
            this.Controls.Add(this.f1tb2);
            this.Controls.Add(this.f1tb1);
            this.Controls.Add(this.f1btn2);
            this.Controls.Add(this.f1btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button f1btn1;
        private System.Windows.Forms.Button f1btn2;
        private System.Windows.Forms.TextBox f1tb1;
        private System.Windows.Forms.TextBox f1tb2;
        private System.Windows.Forms.ComboBox f1cb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

