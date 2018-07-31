using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollManagement1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salaryForm sf1 = new salaryForm();
            sf1.Show();
            this.Hide();
        }

        private void f2btn4_Click(object sender, EventArgs e)
        {
            LoginForm lf1 = new LoginForm();
            lf1.Show();
            this.Hide();
        }

        private void f2btn1_Click(object sender, EventArgs e)
        {
            attendanceForm af1 = new attendanceForm();
            af1.Show();
            this.Hide();
        }

        private void f2btn3_Click(object sender, EventArgs e)
        {
            infoForm ef1 = new infoForm();
            ef1.Show();
            this.Hide();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailForm mf1 = new mailForm();
            mf1.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportForm rf1 = new reportForm();
            rf1.Show();
        }

        private void f2btn5_Click(object sender, EventArgs e)
        {
            leavemng lm1 = new leavemng();
            lm1.Show();
            this.Hide();
        }
    }
}
