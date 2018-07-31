namespace PayRollManagement1
{
    partial class EmployeeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f3btn2 = new System.Windows.Forms.Button();
            this.f3btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // f3btn2
            // 
            this.f3btn2.Location = new System.Drawing.Point(659, 40);
            this.f3btn2.Name = "f3btn2";
            this.f3btn2.Size = new System.Drawing.Size(75, 23);
            this.f3btn2.TabIndex = 1;
            this.f3btn2.Text = "PDF";
            this.f3btn2.UseVisualStyleBackColor = true;
            this.f3btn2.Click += new System.EventHandler(this.f3btn2_Click);
            // 
            // f3btn1
            // 
            this.f3btn1.Location = new System.Drawing.Point(358, 338);
            this.f3btn1.Name = "f3btn1";
            this.f3btn1.Size = new System.Drawing.Size(86, 29);
            this.f3btn1.TabIndex = 2;
            this.f3btn1.Text = "Log Out";
            this.f3btn1.UseVisualStyleBackColor = true;
            this.f3btn1.Click += new System.EventHandler(this.f3btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaveToolStripMenuItem,
            this.mailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.leaveToolStripMenuItem.Text = "Leave";
            this.leaveToolStripMenuItem.Click += new System.EventHandler(this.leaveToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.mailToolStripMenuItem.Text = "Check Mail";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // f3lbl1
            // 
            this.f3lbl1.AutoSize = true;
            this.f3lbl1.Location = new System.Drawing.Point(355, 50);
            this.f3lbl1.Name = "f3lbl1";
            this.f3lbl1.Size = new System.Drawing.Size(31, 13);
            this.f3lbl1.TabIndex = 5;
            this.f3lbl1.Text = "........";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 395);
            this.Controls.Add(this.f3lbl1);
            this.Controls.Add(this.f3btn1);
            this.Controls.Add(this.f3btn2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button f3btn2;
        private System.Windows.Forms.Button f3btn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.Label f3lbl1;
    }
}