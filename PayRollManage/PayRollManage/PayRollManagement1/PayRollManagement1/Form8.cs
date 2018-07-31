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
    public partial class leaveForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
        int diff;
        string days;

        public leaveForm()
        {
            InitializeComponent();
        }
        public void Insert()
        {
            


            con.Open();
            string sql = "INSERT INTO `leave_info` (`em_id`, `leave_type`, `from_date`,`to_date`,`days`,`status`) VALUES('" + f8tb1.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','"+days+ "','" + f8tb3.Text + "')";
            MySqlCommand cmd2 = new MySqlCommand(sql, con);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Submitted Successfully !");
            con.Close();
        }
        public void View()
        {
            try
            {



                con.Open();
                string selQuerry = "Select * from leave_info where em_id ='" + LoginForm.uID + "' ";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(selQuerry, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
               
                con.Close();


                
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leaveForm_Load(object sender, EventArgs e)
        {
            View();
        }

        private void f8btn1_Click(object sender, EventArgs e)
        {
            Insert();
            View();

            //clear
            f8tb1.Clear();
            f8tb2.Clear();
            
            comboBox1.SelectedIndex = 0;
            


        }

        private void dateTimePicker2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void f8tb2_MouseHover(object sender, EventArgs e)
        {
            DateTime st = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date;

            TimeSpan diff1 = end - st;
            diff = (diff1.Days) + 1;

            days= diff.ToString();
            f8tb2.Text = days;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f8tb1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f8tb2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f8tb3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void f8btn2_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();
            pr.Title = "Leave Details\n\n\n";
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
    }
}
