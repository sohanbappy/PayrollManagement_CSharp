using MySql.Data.MySqlClient;
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
    public partial class resignForm : Form
    {
        public resignForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resignForm_Load(object sender, EventArgs e)
        {
            View();
        }
        public void View()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");
                con.Open();
                string qry = "Select * from resign";
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
    }
}
