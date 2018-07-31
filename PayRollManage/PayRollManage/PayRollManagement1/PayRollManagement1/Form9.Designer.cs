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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendbtn = new System.Windows.Forms.Button();
            this.f9btn2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filebtn = new System.Windows.Forms.Button();
            this.atttxt = new System.Windows.Forms.TextBox();
            this.totxt = new System.Windows.Forms.TextBox();
            this.subtxt = new System.Windows.Forms.TextBox();
            this.bodytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
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
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(474, 390);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(231, 86);
            this.sendbtn.TabIndex = 10;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.f9btn1_Click);
            // 
            // f9btn2
            // 
            this.f9btn2.Location = new System.Drawing.Point(81, 390);
            this.f9btn2.Name = "f9btn2";
            this.f9btn2.Size = new System.Drawing.Size(208, 86);
            this.f9btn2.TabIndex = 12;
            this.f9btn2.Text = "Exit";
            this.f9btn2.UseVisualStyleBackColor = true;
            this.f9btn2.Click += new System.EventHandler(this.f9btn2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filebtn
            // 
            this.filebtn.Location = new System.Drawing.Point(515, 289);
            this.filebtn.Name = "filebtn";
            this.filebtn.Size = new System.Drawing.Size(75, 23);
            this.filebtn.TabIndex = 13;
            this.filebtn.Text = "Open";
            this.filebtn.UseVisualStyleBackColor = true;
            this.filebtn.Click += new System.EventHandler(this.f9btn3_Click);
            // 
            // atttxt
            // 
            this.atttxt.Location = new System.Drawing.Point(230, 289);
            this.atttxt.Name = "atttxt";
            this.atttxt.Size = new System.Drawing.Size(273, 20);
            this.atttxt.TabIndex = 14;
            // 
            // totxt
            // 
            this.totxt.Location = new System.Drawing.Point(230, 90);
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(360, 20);
            this.totxt.TabIndex = 15;
            // 
            // subtxt
            // 
            this.subtxt.Location = new System.Drawing.Point(230, 134);
            this.subtxt.Name = "subtxt";
            this.subtxt.Size = new System.Drawing.Size(360, 20);
            this.subtxt.TabIndex = 17;
            // 
            // bodytxt
            // 
            this.bodytxt.Location = new System.Drawing.Point(230, 175);
            this.bodytxt.Multiline = true;
            this.bodytxt.Name = "bodytxt";
            this.bodytxt.Size = new System.Drawing.Size(360, 90);
            this.bodytxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "From";
            // 
            // fromtxt
            // 
            this.fromtxt.Location = new System.Drawing.Point(230, 45);
            this.fromtxt.Name = "fromtxt";
            this.fromtxt.Size = new System.Drawing.Size(360, 20);
            this.fromtxt.TabIndex = 20;
            // 
            // mailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 549);
            this.Controls.Add(this.fromtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bodytxt);
            this.Controls.Add(this.subtxt);
            this.Controls.Add(this.totxt);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.atttxt);
            this.Controls.Add(this.filebtn);
            this.Controls.Add(this.f9btn2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mailForm";
            this.Text = "E-mail";
            this.Load += new System.EventHandler(this.mailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button f9btn2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button filebtn;
        private System.Windows.Forms.TextBox atttxt;
        private System.Windows.Forms.TextBox totxt;
        private System.Windows.Forms.TextBox subtxt;
        private System.Windows.Forms.TextBox bodytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromtxt;
    }
}