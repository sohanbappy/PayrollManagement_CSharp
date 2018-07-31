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
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using DGVPrinterHelper;
using System.Windows.Forms.DataVisualization.Charting;

namespace PayRollManagement1
{
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();
            View();
        }
        public void View()
        {
            try
            {

                MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=payroll;Uid=root;Pwd='';");

                con.Open();
                string selQuerry = "Select em_id,day as total_attendance from attendance where em_id ='" + infoForm.ID + "' ";
                MySqlCommand cmd1 = new MySqlCommand(selQuerry,con);
                MySqlDataReader rdr1 = cmd1.ExecuteReader();
               if(rdr1.Read())
                {
                    this.chart1.Series["total_attendance"].Points.AddXY(rdr1.GetString(0), rdr1.GetDateTime(1));
                }

                con.Close();


                
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void reprtForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Document Doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter.GetInstance(Doc, new FileStream("AttendanceGraph.pdf", FileMode.Create));
                Doc.Open();

                var chartImage = new MemoryStream();
                chart1.SaveImage(chartImage, ChartImageFormat.Png);
                iTextSharp.text.Image CI = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
                Doc.Add(CI);



                Doc.Close();

                MessageBox.Show("Check ur default Folder", "PDF");

            }
            catch
            {
                MessageBox.Show("Something went wrong !!");
            }
        }
    }
}
