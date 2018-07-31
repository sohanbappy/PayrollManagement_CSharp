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
            
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f9tb5.Text = openFileDialog1.FileName;
            }

        }

        private void f9btn1_Click(object sender, EventArgs e)
        {

            login = new NetworkCredential(f9tb6.Text, f9tb7.Text);
            client = new SmtpClient(f9tb9.Text);
            client.Port = Convert.ToInt32(f9tb8.Text);
            client.EnableSsl = sslck.Checked;
            client.Credentials = login;
            //from smtp Gmail
            msg = new MailMessage { From = new MailAddress(f9tb6.Text + f9tb9.Text.Replace("smtp.", "@"), "Lucy", Encoding.UTF8)};
            msg.To.Add(new MailAddress(f9tb1.Text));

            if (!string.IsNullOrEmpty(f9tb2.Text))
            {
                msg.To.Add(new MailAddress(f9tb2.Text));
            }
            //for attachments
               att = new Attachment(@f9tb5.Text);
               msg.Attachments.Add(att);

            msg.Subject = f9tb3.Text;
            msg.Body = f9tb4.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            string userState = "Sending.....";
            client.SendAsync(msg, userState);
        }
        public static void SendCompletedCallBack(object sender,AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} Send Cancelled.",e.UserState),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState,e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your message has been sent successfully !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
