using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;

namespace Gastro
{
    public partial class jelsz : Form
    {
        string mypw = "Monsters1998";
        public jelsz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string getNameOrMail() {
            string m = textBox1.Text;
            return m;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            us u = new us();
            string email = "";
          
            email=u.emailOfUser(textBox1.Text);
            MessageBox.Show(email);

            /*MailMessage mail = new MailMessage("baloghbencefacebook@gmail.com", email);
            MessageBox.Show("Test");
            SmtpClient client = new SmtpClient();
            MessageBox.Show("Test2");
            client.Port = 25;
            MessageBox.Show("Test3");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MessageBox.Show("Test3");
            client.UseDefaultCredentials = false;
            MessageBox.Show("Test4");
            client.Host = "smtp.gmail.com";
            MessageBox.Show("Test5");
            mail.Subject = "this is a test email.";
            MessageBox.Show("Test6");
            mail.Body = "this is my test email body";
            MessageBox.Show("Test7");
            try
            {
                client.Send(mail);
            }
            catch (Exception x) { Debug.WriteLine(x.Message); }
            MessageBox.Show("Test8");*/
            MessageBox.Show("Test");
            MailMessage objeto_mail = new MailMessage();
            MessageBox.Show("Test2");
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.outlook.com";
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
      
            client.EnableSsl = true;
            
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("sz7balben@vasvari.hu", mypw);
            objeto_mail.From = new MailAddress("sz7balben@vasvari.hu");
            objeto_mail.To.Add(new MailAddress("sz7balben@vasvari.hu"));
            objeto_mail.Subject = "Password Recover";
            objeto_mail.Body = "Message";
            MessageBox.Show("Test8");
            client.Send(objeto_mail);
        }
    }
}
