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

namespace TicketManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string query = new " Select * from SignUp where Phone_Number = '" + txtPhoneNumber.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(" Select * from SignUp where Phone_Number = '" + txtPhoneNumber.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                this.Hide();
                new HomePage().Show();
            }
            else
            {
                MessageBox.Show("Check Your Phone Number or Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
