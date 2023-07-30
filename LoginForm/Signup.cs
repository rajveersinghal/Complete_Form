using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginForm
{
    public partial class Signup : Form
    {
      
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=RSINGHAL95\MSSQLSERVER01;Initial Catalog=Form;Integrated Security=True");

        private void Reset()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFname.Text ==""|txtLname.Text==""|txtEmail.Text==""|txtPassword.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into SignUP values('" + txtFname.Text + "','" + txtLname.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SignUp Successfully");
                    con.Close();
                    Reset();    
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
    }
}
