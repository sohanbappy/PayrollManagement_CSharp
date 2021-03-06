﻿using System;
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
    public partial class salaryForm : Form
    {

        string selQuerry = "Select * from salary";
        MySqlConnection con;

        double ded, over ,allowence=0,total,basic;

        public salaryForm()
        {
            InitializeComponent();
           

        }
        public void View(string qry)
        {
            try
            {
              con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void salaryForm_Load(object sender, EventArgs e)
        {

            View(selQuerry);

        }
        public void getValue()
        {
            con.Open();
            string selQuerry = "Select sum(deduction),sum(overtime) from attendance where em_id ='" + f5tb1.Text + "' ";
            MySqlDataAdapter adp = new MySqlDataAdapter(selQuerry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);


            ded = (double)dt.Rows[0][0];
            over = (double)dt.Rows[0][1];

            


            con.Close();
        }
        public void getBasic()
        {
            con.Open();
            string selQuerry = "Select basic from employee_info where em_id ='" + f5tb1.Text + "' ";
            MySqlDataAdapter adp = new MySqlDataAdapter(selQuerry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);


            basic = (double)dt.Rows[0][0];

            


            con.Close();
        }

        private void f5btn1_Click(object sender, EventArgs e)
        {
            AdminForm af1 = new AdminForm();
            af1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f5tb1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f5tb2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f5tb3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f5tb4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f5tb5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f5tb6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getBasic();
            getValue();
            allowence = basic * .01;
            total = ((basic + allowence + over) - ded);
            string insertQry = "INSERT INTO `salary`(`em_ID`, `basic_pay`, `allowence`, `deduction`, `overtime`, `total`) VALUES ('"+f5tb1.Text+"','"+basic+ "','" + allowence + "','" +ded+ "','" + over + "','" + total + "')";
            DbConnection.Insert(insertQry);


            View(selQuerry);
        }

        private void btnsrc_Click(object sender, EventArgs e)
        {

            string selQuerry = "Select * from salary where em_id='"+tbsrc.Text+"'";
            View(selQuerry);

            

        }

        private void f5btn2_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();
            pr.Title = "Salary Details\n\n\n";
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

        private void button1_Click(object sender, EventArgs e)
        {
            getValue();
        }

        public void Calc()
        {
            
        }
    }
}
