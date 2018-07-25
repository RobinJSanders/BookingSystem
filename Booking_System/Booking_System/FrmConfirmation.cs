using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System
{

    public partial class FrmConfirmation : Form
    {

        public FrmConfirmation()
        {
            InitializeComponent();

            //display the user's details
            rtfDetails.Text = User.Fname + " " +
                User.Lname + "\n\n" +
                User.Address1 + "\n" +
                User.Address2 + "\n" +
                User.County + "\n" +
                User.Postcode + "\n\n" +
                User.Email;
            lblSeats.Text += " " + User.Seat1 + " " + User.Seat2 + " " + User.Seat3 + " " + User.Seat4;
            lblReciept.Text += " " + User.Email;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmSelectSeats frmSelectSeats = new FrmSelectSeats();
            frmSelectSeats.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {//add user details to each seat in Seats.Seatlist 
            string row;
            string col;
            Regex regRow = new Regex(@"[A-Z]");
            Regex regCol = new Regex(@"\d+");

            if (User.Seat1 != "")
            {
                row = regRow.Match(User.Seat1).Value;
                col = regCol.Match(User.Seat1).Value;
                Seats.Book(row, col);
            }
            if (User.Seat2 != "")
            {
                row = regRow.Match(User.Seat2).Value;
                col = regCol.Match(User.Seat2).Value;
                Seats.Book(row, col);
            }
            if (User.Seat3 != "")
            {
                row = regRow.Match(User.Seat3).Value;
                col = regCol.Match(User.Seat3).Value;
                Seats.Book(row, col);
            }
            if (User.Seat4 != "")
            {
                row = regRow.Match(User.Seat4).Value;
                col = regCol.Match(User.Seat4).Value;
                Seats.Book(row, col);
            } 
            
            //Add seats to table and reopen FrmDetails
            Seats.WriteSeatTable();
            MessageBox.Show("Your Booking has been confirmed", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmDetails frmDetails = new FrmDetails();
            frmDetails.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
