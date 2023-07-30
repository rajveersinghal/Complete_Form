
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class r_pass : Form
    {
        //string password;
        string email = f_pass.to;
        public r_pass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRreset_Click(object sender, EventArgs e)
        {
            if (txtRPass1.Text == txtRPass2.Text)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=RSINGHAL95\MSSQLSERVER01;Initial Catalog=Form;Integrated Security=True");
                    con.Open();
                    //MessageBox.Show("Success"+email);
                    SqlCommand cmd = new SqlCommand("UPDATE SignUP SET pwd='" + txtRPass2.Text + "' WHERE em='"+email+"'",con);
                    cmd.ExecuteScalar();

                    MessageBox.Show("Reset Successfully");
                }



                catch (Exception exp)
                {

                    MessageBox.Show("Error "+exp);
                }
            }
            else
            {
                MessageBox.Show("Not Match");
            }

        }
    }
}
