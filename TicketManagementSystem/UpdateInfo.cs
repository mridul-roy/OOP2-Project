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
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");


        private void btnCreate_Click(object sender, EventArgs e)
        {
             sqlConnection.Open();
            SqlCommand command = new SqlCommand("update SignUp set Name='" + txtName.Text + "', Email='" + txtEmail.Text + "',  Password='" + txtPassword.Text + "', Confirm_Password='" + txtConfirmPassword.Text + "' where Phone_Number='" + txtPhoneNumber.Text + "'", sqlConnection);
            command.ExecuteNonQuery();
             sqlConnection.Close();
             MessageBox.Show("Updated successfully");
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }
    }
}
