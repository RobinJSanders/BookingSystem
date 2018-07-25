namespace Booking_System
{
    partial class FrmConfirmation
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
            this.rtfDetails = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblReciept = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtfDetails
            // 
            this.rtfDetails.Location = new System.Drawing.Point(12, 39);
            this.rtfDetails.Name = "rtfDetails";
            this.rtfDetails.ReadOnly = true;
            this.rtfDetails.Size = new System.Drawing.Size(334, 266);
            this.rtfDetails.TabIndex = 0;
            this.rtfDetails.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(349, 398);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(13, 13);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(67, 13);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Your Details:";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(16, 312);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(82, 13);
            this.lblSeats.TabIndex = 4;
            this.lblSeats.Text = "Seats Selected:";
            // 
            // lblReciept
            // 
            this.lblReciept.AutoSize = true;
            this.lblReciept.Location = new System.Drawing.Point(19, 352);
            this.lblReciept.Name = "lblReciept";
            this.lblReciept.Size = new System.Drawing.Size(119, 13);
            this.lblReciept.TabIndex = 5;
            this.lblReciept.Text = "A reciept will be sent to:";
            // 
            // FrmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 435);
            this.Controls.Add(this.lblReciept);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtfDetails);
            this.Name = "FrmConfirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfDetails;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblReciept;
    }
}