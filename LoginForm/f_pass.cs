using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_pass : Form
    {
        string randomcode;
        public static string to;
        public f_pass()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RSINGHAL95\MSSQLSERVER01;Initial Catalog=Form;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void f_pass_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void btnFverify_Click(object sender, EventArgs e)
        {
            if(randomcode == (txtFCode.Text).ToString())
            {
                 to=txtFEmail.Text;
                r_pass rp=new r_pass();
                rp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void btnFsend_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random random = new Random();
            randomcode = random.Next(999999).ToString();
            MailMessage message= new MailMessage();
            to = (txtFEmail.Text).ToString();
            from = "rajveer.bcastudent21.25445@cimage.in";
            pass = "RA21@25445";
            messagebody = $"Your Reset Code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body= messagebody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp=new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials=new NetworkCredential(from,pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sucessfully Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }
    }
}
