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
    public partial class EmployeeForm : Form
    {

        //variables
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
        String uID = LoginForm.uID;
        double basic,per_hr=0,per_day;
        string dept;
        int hrs;


        TimeSpan now,in_time;
        public  TimeSpan diff,total_diff;
        public double deduction=0,overtime=0;
       

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/");
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leaveForm lf1 = new leaveForm();
            lf1.Show();
        }

        public EmployeeForm()
        {
            InitializeComponent();
            View();
            StoreBasic();
        }
        public void StoreBasic()
        {
            try
            {
                DbConnection.con.Open();
                string xy = "SELECT basic,dept FROM employee_info Where em_id='" + uID + "'";

                MySqlCommand cmd08 = new MySqlCommand(xy, DbConnection.con);
                 MySqlDataReader rdr = cmd08.ExecuteReader();

                if (rdr.Read())
                {
                    basic = rdr.GetDouble(0);
                    dept = rdr.GetString(1);


                   

                }
                DbConnection.con.Close();
            }
            catch
            {
                MessageBox.Show("Something Wrong !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void f3btn2_Click(object sender, EventArgs e)
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

        public void View()
        {
            try
            {
                
                
                
                con.Open();
                string selQuerry = "Select * from attendance where em_id ='"+uID+"' ";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(selQuerry, con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


                f3lbl1.Text = "Welcome     " + uID;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
        public void Update()
        {
            try
            {
                Calc();

                
                string query2 = "UPDATE attendance SET outtime= CURRENT_TIME(),dept='"+dept+"',working_hr='"+diff+"',deduction='"+deduction+ "',overtime='" + overtime + "'   WHERE em_id ='" + uID + "' and day = CURDATE() ";
                con.Open();
                MySqlCommand cmd5 = new MySqlCommand(query2, con);

                if (cmd5.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Thank You !!");
                    con.Close();
                }
                
                else
                {
                    MessageBox.Show("Update Not Successfull !! U can't login more than one time in a day !");

                }
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
       

                
        public void Calc()
        {
            try
            {



                con.Open();
                string selQuerry = "Select intime from attendance where em_id ='" + uID + "' and day=CURDATE() ";
                MySqlDataAdapter adp = new MySqlDataAdapter(selQuerry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                in_time = (TimeSpan)dt.Rows[0][0];

               
                con.Close();


                //for working_hr
                now = (TimeSpan) DateTime.Now.TimeOfDay;
                diff = now - in_time;

                hrs = (int)diff.TotalHours;


                //for per_hr
                per_day = basic / 22;
                per_hr = per_day / 8;
                


                //for deduction or overtime
                if (hrs > 8)
                {
                    deduction = 0;
                    

                    String day = DateTime.Now.DayOfWeek.ToString();

                    if ( day.Equals("Friday") || day.Equals("Saturday"))
                    {
                        overtime =(1.5 * per_hr * (hrs - 8));

                       
                    }
                    else
                    {
                        overtime = (per_hr * (hrs - 8));

                    }
                }
                else if (hrs < 8)
                {
                    overtime = 0;
                    deduction =(per_hr * (8 -hrs));
                }
                else
                {
                    deduction = 0;
                    overtime = 0;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                con.Close();
            }

        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            View();
        }

        private void f3btn1_Click(object sender, EventArgs e)
        {
            
            Update();
            


            //Log out
           // LoginForm lf1 = new LoginForm();
           // lf1.Show();
            this.Hide();
        }
    }
}
