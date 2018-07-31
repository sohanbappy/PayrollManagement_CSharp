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
    public partial class infoForm : Form
    {
        public static string ID;

        public infoForm()
        {
            InitializeComponent();
          
         
        }
        public void View(string qry)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
                con.Open(); 
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e);
            }
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            string selQuery = "Select * from employee_info";
            View(selQuery);

            comboBox4.SelectedIndex = 0;
        }

        private void f6btn1_Click(object sender, EventArgs e)
        {
            AdminForm af1 = new AdminForm();
            af1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f6tb1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f6tb2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f6tb3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f6tb4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            f6tb5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            f6tb6.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            f6tb7.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();



        }

        private void btnsrc_Click(object sender, EventArgs e)
        {
            ID = tbsrc.Text;

            reportForm rf1 = new reportForm();
            rf1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQry = "INSERT INTO `employee_info`(`em_id`, `name`, `phone`, `designation`, `dept`, `gender`, `date_of_birth`, `date_of_join`, `bl_group`, `basic`, `address`,`password`) VALUES ('" + f6tb1.Text+ "','" + f6tb2.Text + "','" + f6tb3.Text + "','" + f6tb4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + comboBox3.Text + "','" + f6tb5.Text + "','" + f6tb6.Text + "','" + f6tb7.Text + "')";
            DbConnection.Insert(insertQry);

            string selQuery = "Select * from employee_info";
            View(selQuery);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string delQry = "DELETE FROM employee_info WHERE em_id = '" + f6tb1.Text + "' ";
            DbConnection.Delete(delQry);


            string selQuery = "Select * from employee_info";
            View(selQuery);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string updateQry = "UPDATE employee_info SET name= '" + f6tb2.Text + "',phone='" + f6tb3.Text + "',designation='" + f6tb4.Text + "',dept='" + comboBox1.Text + "',gender='" + comboBox2.Text + "',date_of_birth='" + dateTimePicker1.Text + "',date_of_join='" + dateTimePicker2.Text + "',bl_group='" + comboBox3.Text + "',basic='" + f6tb5.Text + "',address='" + f6tb6.Text + "',password='" + f6tb7.Text + "'   WHERE em_id ='" + f6tb1.Text + "' ";
            DbConnection.Update(updateQry);

            string selQuery = "Select * from employee_info";
            View(selQuery);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selQuery;
            string dept = comboBox4.Text;

            if (dept == "All")
            {
                selQuery = "select * from employee_info";
            }
            else
            {
                selQuery = "select * from employee_info where dept='" + comboBox4.Text + "' ";
            }
            View(selQuery);
        }

        private void tbnsrc_Click(object sender, EventArgs e)
        {
            string selQuery = "Select * from employee_info where em_id='"+tbsrc.Text+"'";
            View(selQuery);
        }

        private void manageResignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string delQry = "DELETE FROM employee_info WHERE em_id = '" + f6tb1.Text + "' ";
            DbConnection.Delete(delQry);

            //for insert into Resign Table
            string ins = "INSERT INTO `resign`(`em_id`, `name`, `date_of_resign`) VALUES ('"+f6tb1.Text+ "','" + f6tb2.Text + "',CURDATE())";
            DbConnection.Insert(ins);

            //for Viewing Resign Table
            resignForm rf1 = new resignForm();
            rf1.Show();

            string selQuery = "Select * from employee_info";
            View(selQuery);
        }

        private void f6btn2_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();
            pr.Title = "Employee Details\n\n\n";
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
