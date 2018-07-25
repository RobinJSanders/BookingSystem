using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System
{

    public partial class FrmDetails : Form
    {
        public FrmDetails()
        {
            InitializeComponent();

            //restore textbox data when pressing back button on FrmSelectSeats
            txtFName.Text = User.Fname;
            txtLName.Text = User.Lname;
            txtAddress1.Text = User.Address1;
            txtAddress2.Text = User.Address2;
            txtPostCode.Text = User.Postcode;
            txtCounty.Text = User.County;
            txtEmail.Text = User.Email;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Regex regName = new Regex(@"[A-Za-z]");
            Regex regPostCode = new Regex(@"^(([gG][iI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0-9][0-9]?)|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW])|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9][abehmnprv-yABEHMNPRV-Y]))) {0,}[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$");
            Regex regEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //check whether email is already registered
            bool emailRegestered = false;
            foreach (Seat seat in Seats.SeatList)
                if (seat.Email == txtEmail.Text)
                {
                    emailRegestered = true;
                    break;
                }

            if(emailRegestered)
            {
                MessageBox.Show("This Email Address has already been registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFName.Text == "" || txtLName.Text == "" || txtAddress1.Text == "" || txtPostCode.Text == "" || txtCounty.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please complete form to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!regName.IsMatch(txtFName.Text) || !regName.IsMatch(txtLName.Text) || !regName.IsMatch(txtCounty.Text) || !regPostCode.IsMatch(txtPostCode.Text) || !regEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("A field is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//add user details and confirm if no errors
                User.Fname = txtFName.Text;
                User.Lname = txtLName.Text;
                User.Address1 = txtAddress1.Text;
                User.Address2 = txtAddress2.Text;
                User.Postcode = txtPostCode.Text;
                User.County = txtCounty.Text;
                User.Email = txtEmail.Text;
                FrmSelectSeats frmSelectSeats = new FrmSelectSeats();
                frmSelectSeats.Show();
                this.Hide();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
