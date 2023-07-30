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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class LogIn : Form
    {

 
        public LogIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RSINGHAL95\MSSQLSERVER01;Initial Catalog=Form;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            reader.connect();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, password;
            user=txtUser.Text;
            password=txtPassword.Text;

            try
                {
                // Create a SQL query to check the username and password
                string query = "SELECT * FROM SignUP WHERE em ='" + user + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.GetString(3).Equals(password))
                    {
                        MessageBox.Show("Login Successful");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user");
                    con.Close() ;
                }
             
                
            }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error"+Ex.Message);
                }

            }

        private void label3_Click(object sender, EventArgs e)
        {
            
            new Signup().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new f_pass().Show();
            this.Hide() ;
        }
    }
}
