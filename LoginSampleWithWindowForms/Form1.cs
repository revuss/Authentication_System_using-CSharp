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

namespace LoginSampleWithWindowForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-28T4EQ8\\SQLEXPRESS; Database = ConCSharp; Integrated Security  = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Account where username = '" + txtuser.Text + "' and password='" + txtpass.Text + "'",conn);

            SqlDataReader sqr;
            sqr= cmd.ExecuteReader();
            if (sqr.Read())
            {
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else 
            {
                MessageBox.Show("wrong", "sa", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
               conn.Close();    
        }
    }
}
