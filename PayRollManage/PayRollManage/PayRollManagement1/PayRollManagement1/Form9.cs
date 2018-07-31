using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace PayRollManagement1
{
    public partial class mailForm : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        Attachment att;


        public mailForm()
        {
            InitializeComponent();
        }

        private void f9btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sslck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void f9btn3_Click(object sender, EventArgs e)
        {


            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                atttxt.Text = fd.FileName.ToString();
            }

        }

        private void f9btn1_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("jahanarasweety@gmail.com", "ahsan1315");
                MailMessage msg = new MailMessage();
                msg.To.Add(totxt.Text);
                msg.From = new MailAddress(fromtxt.Text);
                msg.Subject = subtxt.Text;
                msg.Body = bodytxt.Text;
                Attachment att = new Attachment(atttxt.Text);
                msg.Attachments.Add(att);

                client.Send(msg);
                MessageBox.Show("Sent Successful !!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong !!" + ex);
            }
        }

        private void mailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
