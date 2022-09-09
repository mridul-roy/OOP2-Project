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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into Payment(Phone_Number,bKash,Rocket,Nagad) values('"+txtPhoneNumber.Text.Trim()+"','" + txtBkash.Text + "','"+txtRocket.Text+"','"+txtNagad.Text+"')", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Payment Completed");

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }
    }
}
