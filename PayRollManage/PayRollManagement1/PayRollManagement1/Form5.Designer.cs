namespace PayRollManagement1
{
    partial class salaryForm
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
            this.f5tb1 = new System.Windows.Forms.TextBox();
            this.f5tb2 = new System.Windows.Forms.TextBox();
            this.f5tb3 = new System.Windows.Forms.TextBox();
            this.f5tb4 = new System.Windows.Forms.TextBox();
            this.f5tb5 = new System.Windows.Forms.TextBox();
            this.f5tb6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f5btn1 = new System.Windows.Forms.Button();
            this.f5btn2 = new System.Windows.Forms.Button();
            this.tbsrc = new System.Windows.Forms.TextBox();
            this.btnsrc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Allowence";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deduction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Overtime";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // f5tb1
            // 
            this.f5tb1.Location = new System.Drawing.Point(154, 75);
            this.f5tb1.Name = "f5tb1";
            this.f5tb1.Size = new System.Drawing.Size(100, 20);
            this.f5tb1.TabIndex = 6;
            // 
            // f5tb2
            // 
            this.f5tb2.Location = new System.Drawing.Point(154, 116);
            this.f5tb2.Name = "f5tb2";
            this.f5tb2.Size = new System.Drawing.Size(100, 20);
            this.f5tb2.TabIndex = 7;
            // 
            // f5tb3
            // 
            this.f5tb3.Location = new System.Drawing.Point(154, 150);
            this.f5tb3.Name = "f5tb3";
            this.f5tb3.Size = new System.Drawing.Size(100, 20);
            this.f5tb3.TabIndex = 8;
            // 
            // f5tb4
            // 
            this.f5tb4.Location = new System.Drawing.Point(425, 75);
            this.f5tb4.Name = "f5tb4";
            this.f5tb4.Size = new System.Drawing.Size(100, 20);
            this.f5tb4.TabIndex = 9;
            // 
            // f5tb5
            // 
            this.f5tb5.Location = new System.Drawing.Point(425, 108);
            this.f5tb5.Name = "f5tb5";
            this.f5tb5.Size = new System.Drawing.Size(100, 20);
            this.f5tb5.TabIndex = 10;
            // 
            // f5tb6
            // 
            this.f5tb6.Location = new System.Drawing.Point(425, 150);
            this.f5tb6.Name = "f5tb6";
            this.f5tb6.Size = new System.Drawing.Size(100, 20);
            this.f5tb6.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // f5btn1
            // 
            this.f5btn1.Location = new System.Drawing.Point(274, 381);
            this.f5btn1.Name = "f5btn1";
            this.f5btn1.Size = new System.Drawing.Size(115, 33);
            this.f5btn1.TabIndex = 13;
            this.f5btn1.Text = "Back";
            this.f5btn1.UseVisualStyleBackColor = true;
            this.f5btn1.Click += new System.EventHandler(this.f5btn1_Click);
            // 
            // f5btn2
            // 
            this.f5btn2.Location = new System.Drawing.Point(566, 139);
            this.f5btn2.Name = "f5btn2";
            this.f5btn2.Size = new System.Drawing.Size(75, 31);
            this.f5btn2.TabIndex = 14;
            this.f5btn2.Text = "PDF";
            this.f5btn2.UseVisualStyleBackColor = true;
            this.f5btn2.Click += new System.EventHandler(this.f5btn2_Click);
            // 
            // tbsrc
            // 
            this.tbsrc.Location = new System.Drawing.Point(70, 27);
            this.tbsrc.Name = "tbsrc";
            this.tbsrc.Size = new System.Drawing.Size(184, 20);
            this.tbsrc.TabIndex = 15;
            // 
            // btnsrc
            // 
            this.btnsrc.Location = new System.Drawing.Point(274, 27);
            this.btnsrc.Name = "btnsrc";
            this.btnsrc.Size = new System.Drawing.Size(129, 20);
            this.btnsrc.TabIndex = 16;
            this.btnsrc.Text = "Search";
            this.btnsrc.UseVisualStyleBackColor = true;
            this.btnsrc.Click += new System.EventHandler(this.btnsrc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 71);
            this.button2.TabIndex = 18;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsrc);
            this.Controls.Add(this.tbsrc);
            this.Controls.Add(this.f5btn2);
            this.Controls.Add(this.f5btn1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.f5tb6);
            this.Controls.Add(this.f5tb5);
            this.Controls.Add(this.f5tb4);
            this.Controls.Add(this.f5tb3);
            this.Controls.Add(this.f5tb2);
            this.Controls.Add(this.f5tb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "salaryForm";
            this.Text = "Salary Info";
            this.Load += new System.EventHandler(this.salaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox f5tb1;
        private System.Windows.Forms.TextBox f5tb2;
        private System.Windows.Forms.TextBox f5tb3;
        private System.Windows.Forms.TextBox f5tb4;
        private System.Windows.Forms.TextBox f5tb5;
        private System.Windows.Forms.TextBox f5tb6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button f5btn1;
        private System.Windows.Forms.Button f5btn2;
        private System.Windows.Forms.TextBox tbsrc;
        private System.Windows.Forms.Button btnsrc;
        private System.Windows.Forms.Button button2;
    }
}