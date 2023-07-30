using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace LoginForm
{
    internal class reader
    {
         public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter rd;
        public static void connect()
        {
            try
            {
                conn = new SqlConnection("Data Source=RSINGHAL95\\MSSQLSERVER01;Initial Catalog=Form;Integrated Security=True");
                conn.Open();
            }
            catch (Exception exp)
            {

                MessageBox.Show("Sorry Something went Wrong !" + exp.Message);
            }
        }
    }
}
