using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PayRollManagement1
{
    public class DbConnection
    {
        public static MySqlConnection  con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
        public static MySqlCommand cmd,cmd1,cmd2;


        public static void Insert(string query)
        {
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully !!");
            con.Close();

           
        }
        public static void Update(string query)
        {
            try { 
            con.Open();
            cmd1 = new MySqlCommand(query, con);

            if (cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Updated Successfully !!");
                con.Close();
            }

            else
            {
                MessageBox.Show("Updated Not Successfull !!");

            }
            con.Close();
        }
            catch(Exception e)
            {
                MessageBox.Show(" " + e);
            }


}
        public static void Delete(string query)
        {
            try
            {

                con.Open();
                cmd2 = new MySqlCommand(query,con);

                if (cmd2.ExecuteNonQuery() == 1)
                {
                       MessageBox.Show("DELETED");
                }
                else
                {
                    MessageBox.Show("NOT DELETED");
                    con.Close();
                }
               con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Select(string query)
        {

        }

    }
}
