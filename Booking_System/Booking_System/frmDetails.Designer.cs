namespace Booking_System
{
    partial class frmDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblPoscode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(17, 18);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(206, 18);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(17, 48);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblAddress1.TabIndex = 2;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(17, 73);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblAddress2.TabIndex = 3;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblPoscode
            // 
            this.lblPoscode.AutoSize = true;
            this.lblPoscode.Location = new System.Drawing.Point(210, 51);
            this.lblPoscode.Name = "lblPoscode";
            this.lblPoscode.Size = new System.Drawing.Size(55, 13);
            this.lblPoscode.TabIndex = 4;
            this.lblPoscode.Text = "Postcode:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(222, 78);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 5;
            this.lblCounty.Text = "County:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(84, 18);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 6;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(274, 17);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 20);
            this.txtLname.TabIndex = 7;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(104, 48);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(100, 20);
            this.txtAddress1.TabIndex = 8;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(104, 75);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(100, 20);
            this.txtAddress2.TabIndex = 9;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(272, 51);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtPostcode.TabIndex = 10;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(272, 78);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Next >";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblPoscode);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Name = "frmDetails";
            this.Text = "Input Your Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblPoscode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Button button1;
    }
}

