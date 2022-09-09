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
    public partial class Airplane : Form
    {
        public Airplane()
        {
            InitializeComponent();
        }
        string Air_Seat;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P15S13AG;Initial Catalog=DB_TicketMS;Integrated Security=True");

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }

        private void linkHome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HomePage().Show();

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Payment().Show();
        }

        private void btnConfirmAir_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into BookingAir(Phone_Number,Name,Pick_Up,Land,Seat_Number,DateandTime) values('" + txtPhoneNumber.Text + "','" + txtName.Text + "','" + txtFromAir.Text + "','" + txtToAir.Text + "','" + Air_Seat + "','" + dateTimeAir.Value.ToString() + "')", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Confirmed");
        }

        private void chkA01Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-01";
        }

        private void chkA02Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-02";
        }

        private void chkA03Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-03";
        }

        private void chkA04Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-04";
        }

        private void chkA05Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-05";
        }

        private void chkA06Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-06";
        }

        private void chkA07Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-07";
        }

        private void chkA08Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-08";
        }

        private void chkA09Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-09";
        }

        private void chkA10Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-10";
        }

        private void chkA11Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-11";
        }

        private void chkA12Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-12";
        }

        private void chkA13Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-13";
        }

        private void chkA14Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-14";
        }

        private void chkA15Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-15";
        }

        private void chkA16Air_CheckedChanged(object sender, EventArgs e)
        {
            Air_Seat = "A-16";
        }
    }
}
