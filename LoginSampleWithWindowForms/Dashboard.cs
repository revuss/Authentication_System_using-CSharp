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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btncle_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtlastname.Text = string.Empty;
            txtemail.Text = string.Empty;   
            txtGen.Text = string.Empty;
            txtfirstname.Text = string.Empty;   
            txtsal.Text = string.Empty; 
            txtdate.Text = string.Empty;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadDatainfield() 
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-28T4EQ8\\SQLEXPRESS; Database = ConCSharp;Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataviewGrid.DataSource = bs;
            sda.Update(dt);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadDatainfield();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-28T4EQ8\\SQLEXPRESS; Database = ConCSharp;Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Employee]   ([ID] ,[Firstname] ,[Lastname]  ,[Email] ,[Gender],[Salary]  ,[HireDate])     VALUES('"+txtID.Text+"','"+txtfirstname.Text+"','"+txtlastname.Text+"','"+txtemail.Text+"','"+txtGen.Text+"','"+txtsal.Text+"','"+txtdate.Value+"')",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Enterred", "Success", MessageBoxButtons.OK);
            loadDatainfield();
            conn.Close();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-28T4EQ8\\SQLEXPRESS; Database = ConCSharp;Integrated Security = True" );
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Employee] SET [Firstname] = '"+txtfirstname.Text+"',[Lastname]='"+txtlastname.Text+"',[Email] = '"+txtemail.Text+"',[Gender]='"+txtGen.Text+"',[Salary] = '"+txtsal.Text+"',[HireDate]='"+txtdate.Value+"' WHERE [ID] = '"+txtID.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated", "Success", MessageBoxButtons.OK);
            loadDatainfield();
            con.Close();    
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-28T4EQ8\\SQLEXPRESS; Database = ConCSharp;Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from [Employee]  WHERE [ID] = '" + txtID.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted", "Success", MessageBoxButtons.OK);
            loadDatainfield();
            con.Close();
        }
    }
}
