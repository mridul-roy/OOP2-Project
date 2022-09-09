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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Hide();
            new Login().Show();


        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");
        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into SignUp(Name,Phone_Number,Email,Password,Confirm_Password) values('" + txtName.Text + "','" + txtPhoneNumber.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "')", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Inserted successfully");
        }

       /* private void chkA1Bus_CheckedChanged(object sender, EventArgs e)
        {
            Seat_Bus = "A1";
        }

        private void chkA2Bus_CheckedChanged(object sender, EventArgs e)
        {
            Seat_Bus = "A1";
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
     
        }
    }
}
