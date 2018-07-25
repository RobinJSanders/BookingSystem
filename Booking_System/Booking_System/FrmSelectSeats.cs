using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Booking_System
{
    public partial class FrmSelectSeats : Form
    {
        public FrmSelectSeats()
        {
            InitializeComponent();
            //set seats if previosly selected (back button on FrmConfirmation)
            if (User.Seat1 != null)
            {
                cbxRow1.Text = Regex.Match(User.Seat1, @"[A-Z]").Value;
                cbxCol1.Text = Regex.Match(User.Seat1, @"\d+").Value;
            }
            if (User.Seat2 != null)
            {
                cbxRow2.Text = Regex.Match(User.Seat2, @"[A-Z]").Value;
                cbxCol2.Text = Regex.Match(User.Seat2, @"\d+").Value;
            }
            if (User.Seat3 != null)
            {
                cbxRow3.Text = Regex.Match(User.Seat3, @"[A-Z]").Value;
                cbxCol3.Text = Regex.Match(User.Seat3, @"\d+").Value;
            }
            if (User.Seat4 != null)
            {
                cbxRow4.Text = Regex.Match(User.Seat4, @"[A-Z]").Value;
                cbxCol4.Text = Regex.Match(User.Seat4, @"\d+").Value;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDetails frmDetails = new FrmDetails();
            frmDetails.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool previouslyBooked = false;

            //assign previouslyBooked to use in conditional statement check if seat has already been booked
            foreach (Seat seat in Seats.SeatList)
                if ((seat.Row == cbxRow1.Text && seat.Column == cbxCol1.Text) || (seat.Row == cbxRow2.Text && seat.Column == cbxCol2.Text) || (seat.Row == cbxRow3.Text && seat.Column == cbxCol3.Text) || (seat.Row == cbxRow4.Text && seat.Column == cbxCol4.Text))
                {
                    if (seat.Occupied)
                        previouslyBooked = true;
                    break;
                }
            if(cbxRow1.Text == "" && cbxCol1.Text == "" && cbxRow2.Text == "" && cbxCol2.Text == "" && cbxRow3.Text == "" && cbxCol3.Text == "" && cbxRow4.Text == "" && cbxCol4.Text == "")
            {
                MessageBox.Show("Please select at least 1 seat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (previouslyBooked)
            {
                MessageBox.Show("One or more seats have already been booked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((cbxCol1.Text != "") ^ (cbxRow1.Text != "")) || ((cbxCol2.Text != "") ^ (cbxRow2.Text != "")) || ((cbxCol3.Text != "") ^ (cbxRow3.Text != "")) || ((cbxCol4.Text != "") ^ (cbxRow4.Text != "")))
            {
                MessageBox.Show("You may not select a row without a column or column without a row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string seat1 = cbxRow1.Text + cbxCol1.Text;
                string seat2 = cbxRow2.Text + cbxCol2.Text;
                string seat3 = cbxRow3.Text + cbxCol3.Text;
                string seat4 = cbxRow4.Text + cbxCol4.Text;


                if ((seat1 != "" && (seat1 == seat2 || seat1 == seat3 || seat1 == seat4)) || (seat2 != "" && (seat2 == seat3 || seat2 == seat4)) || (seat3 != "" && seat3 == seat4))
                    MessageBox.Show("You may not select the same seat twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {//assign seats to user and opens FrmConfirmation if no errors
                    User.Seat1 = seat1;
                    User.Seat2 = seat2;
                    User.Seat3 = seat3;
                    User.Seat4 = seat4;
                    FrmConfirmation frmconfirmation = new FrmConfirmation();
                    frmconfirmation.Show();
                    this.Hide();
                }
            }
        }

        //buttons which display whether seat is availiable
        private void btnCheck1_Click(object sender, EventArgs e)
        {
            if (cbxRow1.Text != "" && cbxCol1.Text != "")
                foreach (Seat seat in Seats.SeatList)
                    if (seat.Row == cbxRow1.Text && seat.Column == cbxCol1.Text)
                    {
                        if (seat.Occupied)
                            lblAvailable1.Text = "Booked";
                        else
                            lblAvailable1.Text = "Available";
                        break;
                    }
                    else
                        lblAvailable1.Text = "-";
        }

        private void btnCheck2_Click(object sender, EventArgs e)
        {
            if (cbxRow2.Text != "" && cbxCol2.Text != "")
                foreach (Seat seat in Seats.SeatList)
                    if (seat.Row == cbxRow2.Text && seat.Column == cbxCol2.Text)
                    {
                        if (seat.Occupied)
                            lblAvailable2.Text = "Booked";
                        else
                            lblAvailable2.Text = "Available";
                        break;
                    }
                    else
                        lblAvailable2.Text = "-";
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if (cbxRow3.Text != "" && cbxCol3.Text != "")
                foreach (Seat seat in Seats.SeatList)
                    if (seat.Row == cbxRow3.Text && seat.Column == cbxCol3.Text)
                    {
                        if (seat.Occupied)
                            lblAvailable3.Text = "Booked";
                        else
                            lblAvailable3.Text = "Available";
                        break;
                    }
                    else
                        lblAvailable3.Text = "-";
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            if (cbxRow4.Text != "" && cbxCol4.Text != "")
                foreach (Seat seat in Seats.SeatList)
                    if (seat.Row == cbxRow4.Text && seat.Column == cbxCol4.Text)
                    {
                        if (seat.Occupied)
                            lblAvailable4.Text = "Booked";
                        else
                            lblAvailable4.Text = "Available";
                        break;
                    }
                    else
                        lblAvailable4.Text = "-";
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            btnCheck1_Click(sender, e);
            btnCheck2_Click(sender, e);
            btnCheck3_Click(sender, e);
            btnCheck4_Click(sender, e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
