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
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
        }
        string Train_Seat;
        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }

        private void chkA10Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-10";
        }

        private void chkA01Train_CheckedChanged(object sender, EventArgs e)
        {
          Train_Seat = "A-01";

        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");

        private void btnConfirmBus_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into BookingTrain(Phone_Number,Name,Pick_Up,Land,Seat_NumTrain,DateandTime) values('" + txtPhoneNumber.Text + "','" + txtName.Text + "','" + txtFromTrain.Text + "','" + txtToTrain.Text + "','" + Train_Seat + "','" + dateTimeTrain.Value.ToString() + "')", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Confirmed");
        }

        private void chkA02Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-02";
        }

        private void chkA03Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-03";
        }

        private void chkA04Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-04";
        }

        private void chkA05Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-05";
        }

        private void chkA06Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-06";
        }

        private void chkA07Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-07";
        }

        private void chkA08Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-08";
        }

        private void chkA09Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-09";
        }

        private void chkA11Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-11";
        }

        private void chkA12Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-12";
        }

        private void chkA13Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-13";
        }

        private void chkA14Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-14";
        }

        private void chkA15Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-15";
        }

        private void chkA16Train_CheckedChanged(object sender, EventArgs e)
        {
            Train_Seat = "A-16";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Payment().Show();
        }

        private void linkHome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }
    }
}
