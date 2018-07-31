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
    public partial class leavemng : Form
    {
        string Sl;

        string selQuerry = "Select * from leave_info";
        public leavemng()
        {
            InitializeComponent();
        }
        public void View( string query)
        {
            try
            {



                DbConnection.con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, DbConnection.con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                DbConnection.con.Close();



            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string query = "UPDATE leave_info SET status='"+comboBox2.Text+"'   WHERE Sl ='" + Sl + "' ";
           DbConnection.Update(query);
           View(selQuerry);
            
        }

        private void leavemng_Load(object sender, EventArgs e)
        {
            View(selQuerry);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm af1=new AdminForm();
            af1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sl = dataGridView1.CurrentRow.Cells[0].Value.ToString();


            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string qry = "Select * from leave_info where em_id='"+textBox3.Text+"'";
            View(qry);
        }

        private void button2_Click(object sender, EventArgs e)
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
