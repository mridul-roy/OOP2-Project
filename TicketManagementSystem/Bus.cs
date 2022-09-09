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
    public partial class Bus : Form
    {
        string Bus_Seat;
        public Bus()
        {
            InitializeComponent();
        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");

        private void btnConfirmBus_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into Seat_Number(Phone_Number,Name,Pick_Up,Land,Seat_Number,DateandTime) values('" + txtPhoneNumber.Text + "','" + txtName.Text + "','" + txtFromBus.Text + "','" + txtToBus.Text + "','" + Bus_Seat + "','"+dateTimeBus.Value.ToString()+"')", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Confirmed");

        }

        private void chkA1Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "A1";
        }

        private void chkA2Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "A2";
        }

        private void lblPickSeat_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Payment().Show();

        }

        private void chkA3Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "A3";
        }

        private void chkA4Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "A4";
        }

        private void chkB1Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "B1";
        }

        private void chkB2Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "B2";
        }

        private void chkB3Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "B3";
        }

        private void chkB4Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "B4";
        }

        private void chkC1Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "C1";
        }

        private void chkC2Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "C2";
        }

        private void chkC3Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "C3";
        }

        private void chkC4Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "C4";
        }

        private void chkD1Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "D1";
        }

        private void chkD2Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "D2";
        }

        private void chkD3Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "D3";
        }

        private void chkD4Bus_CheckedChanged(object sender, EventArgs e)
        {
            Bus_Seat = "D4";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFromBus_Click(object sender, EventArgs e)
        {

        }

        private void lblToBus_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
