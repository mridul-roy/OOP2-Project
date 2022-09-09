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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void linkBus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new BusSelection().Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");

        private void linkTrain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new TrainSelection().Show();
        }

        private void linkAirplane_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AirSelection().Show();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(" Select * from SignUp where Phone_Number = '" + txtPhoneNumber.Text.Trim() + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            this.Hide();
            new UpdateInfo().Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("delete from SignUp where Phone_Number='" + txtPhoneNumber.Text + "'", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deleted successfully");
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTicketInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketInfo().Show();
        }
    }
}
