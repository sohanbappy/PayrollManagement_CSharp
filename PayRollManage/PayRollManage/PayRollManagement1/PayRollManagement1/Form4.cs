using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DGVPrinterHelper;

namespace PayRollManagement1
{
    public partial class attendanceForm : Form
    {

        string selQuery = "Select * from attendance";

        public attendanceForm()
        {
            InitializeComponent();
            View(selQuery);

            comboBox1.SelectedIndex = 0;
        }
        public void View(string query)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
        private void f4btn1_Click(object sender, EventArgs e)
        {
            AdminForm af1 = new AdminForm();
            af1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            f4tb1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f4tb3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f4tb2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selQuery;
            string dept = comboBox1.Text;

            if (dept == "All")
            {
                selQuery = "select * from attendance";
            }
            else
            {
                selQuery = "select * from attendance where dept='" + comboBox1.Text + "' ";
            }
            View(selQuery);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selqry = "Select * from attendance where em_id='"+f4tb1.Text+"'";
            View(selQuery);
        }

        private void f4btn2_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();
            pr.Title = "Attendance Details\n\n\n";
            pr.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            pr.PageNumbers = true;
            pr.PageNumberInHeader = false;
            pr.PorportionalColumns = true;
            pr.HeaderCellAlignment = StringAlignment.Near;
            pr.Footer = "Created by Jahanara";
            pr.FooterSpacing = 15;
            pr.PrintDataGridView(dataGridView1);


            MessageBox.Show("Pdf Creadted !!");
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            selQuery = "select * from attendance where em_id='" + txtsrc.Text + "' ";
            
            View(selQuery);
        }

        

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            selQuery = "select * from attendance where em_id='"+txtsrc.Text+"' AND day  BETWEEN '" + dateTimePicker4.Value.ToString("yyyy/MM/dd") + "' AND '" + dateTimePicker5.Value.ToString("yyyy/MM/dd") + "' ";

            View(selQuery);
        }
    }
}
