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
           




                uID = f1tb1.Text;

            try
            {
                if (f1cb1.Text == "admin")
                {
                    DbConnection.con.Open();
                    MySqlCommand cmd = DbConnection.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from login where em_id ='" + f1tb1.Text + "' and type='" + f1cb1.Text + "'";
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {

                        if (rd.Read())
                        {

                            if (rd.GetString("em_id").Equals(f1tb1.Text) && rd.GetString("password").Equals(f1tb2.Text) && rd.GetString("type").Equals(f1cb1.Text))
                            {
                                try
                                {
                                    DbConnection.con.Close();
                                    //Admin
                                    //this.Hide();
                                    AdminForm m = new AdminForm();
                                    m.Show();


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex);
                                    DbConnection.con.Close();
                                }
                                finally
                                {
                                    DbConnection.con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Info is not Correct !!!");
                            }
                        }
                        DbConnection.con.Close();
                    }

                }
                else if (f1cb1.Text == "employee")
                {
                    DbConnection.con.Open();
                    MySqlCommand cmd1 = DbConnection.con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select password from employee_info where em_id ='" + f1tb1.Text + "' ";
                    MySqlDataReader rd1 = cmd1.ExecuteReader();
                    if (rd1.HasRows)
                    {

                        if (rd1.Read())
                        {

                            if (rd1.GetString("password").Equals(f1tb2.Text))
                            {
                                DbConnection.con.Close();
                                try
                                {

                                    string sql = "INSERT INTO `attendance` (`em_id`, `intime`, `outtime`,`working_hr`,`day`) VALUES('" + f1tb1.Text + "', CURRENT_TIME(), Null,NUll,CURDATE())";
                                    DbConnection.Insert(sql);

                                    //employee
                                    //this.Hide();
                                    EmployeeForm m = new EmployeeForm();
                                    m.Show();


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex);
                                    DbConnection.con.Close();

                                }
                                finally
                                {
                                    DbConnection.con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("U r not registered !!!");
                                DbConnection.con.Close();
                            }

                        }
                        DbConnection.con.Close();
                    }
                    DbConnection.con.Close();
                }

                else
                {
                    MessageBox.Show("Info is not Correct !!");
                }
            }
            catch
            {
                MessageBox.Show("Info is not Correct !!");
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

