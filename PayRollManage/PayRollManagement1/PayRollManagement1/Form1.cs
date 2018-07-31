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

namespace PayRollManagement1
{
    public partial class LoginForm : Form
    {

        public static String uID;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void f1btn1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");

                
                 uID = f1tb1.Text;

                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from login where em_id ='" + f1tb1.Text + "' and type='" + f1cb1.Text + "'";
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {

                    while (rd.Read())
                    {

                        if (rd.GetString("em_id").Equals(f1tb1.Text))
                        {

                            if (rd.GetString("password").Equals(f1tb2.Text))
                            {
                                if (f1cb1.Text.ToString().Equals("Employee"))
                                {
                                    try
                                    {

                                        MySqlConnection con2 = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
                                        con2.Open();
                                        string sql = "INSERT INTO `attendance` (`em_id`, `intime`, `outtime`,`working_hr`,`day`) VALUES('" + f1tb1.Text + "', CURRENT_TIME(), Null,NUll,CURDATE())";
                                        MySqlCommand cmd2 = new MySqlCommand(sql, con2);
                                        cmd2.ExecuteNonQuery();
                                        con2.Close();
                                        //employee
                                        this.Hide();
                                        EmployeeForm m = new EmployeeForm();
                                        m.Show();
                                    }
                                    catch (Exception ex)
                                    {
                                    MessageBox.Show("Error: " + ex);
                                }

                               }
                                else if (f1cb1.Text.ToString().Equals("Admin"))
                            {
                                try
                                {

                                   
                                    //Admin
                                    this.Hide();
                                    AdminForm m = new AdminForm();
                                    m.Show();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: "+ex);
                                }
                            }
                                else
                                {

                                    this.Hide();
                                    LoginForm m = new LoginForm();
                                    m.Show();
                                }

                            }
                            else
                            {


                            MessageBox.Show("You have entered invalid username and password");
                            }
                        }




                    }
                }
                else
                {


                MessageBox.Show("You are not registered !!");
            }





                con.Close();
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f1btn2_Click(object sender, EventArgs e)
        {
            f1tb1.Clear();
            f1tb2.Clear();
            f1cb1.SelectedIndex = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            f1cb1.SelectedIndex = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm af1 = new aboutForm();
            af1.Show();
        }
    }
    }

