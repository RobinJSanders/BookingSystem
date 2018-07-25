namespace Booking_System
{
    partial class FrmSelectSeats
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
            this.lblSeat1 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.cbxRow1 = new System.Windows.Forms.ComboBox();
            this.cbxCol1 = new System.Windows.Forms.ComboBox();
            this.lblSeat2 = new System.Windows.Forms.Label();
            this.lblSeat3 = new System.Windows.Forms.Label();
            this.lblSeat4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbxCol2 = new System.Windows.Forms.ComboBox();
            this.cbxRow2 = new System.Windows.Forms.ComboBox();
            this.cbxCol3 = new System.Windows.Forms.ComboBox();
            this.cbxRow3 = new System.Windows.Forms.ComboBox();
            this.cbxCol4 = new System.Windows.Forms.ComboBox();
            this.cbxRow4 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheck1 = new System.Windows.Forms.Button();
            this.btnCheck2 = new System.Windows.Forms.Button();
            this.btnCheck3 = new System.Windows.Forms.Button();
            this.btnCheck4 = new System.Windows.Forms.Button();
            this.lblAvailable1 = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblAvailable2 = new System.Windows.Forms.Label();
            this.lblAvailable3 = new System.Windows.Forms.Label();
            this.lblAvailable4 = new System.Windows.Forms.Label();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeat1
            // 
            this.lblSeat1.AutoSize = true;
            this.lblSeat1.Location = new System.Drawing.Point(12, 56);
            this.lblSeat1.Name = "lblSeat1";
            this.lblSeat1.Size = new System.Drawing.Size(74, 13);
            this.lblSeat1.TabIndex = 0;
            this.lblSeat1.Text = "Select Seat 1:";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(103, 36);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(32, 13);
            this.lblRow.TabIndex = 1;
            this.lblRow.Text = "Row ";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(167, 36);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(42, 13);
            this.lblCol.TabIndex = 2;
            this.lblCol.Text = "Colomn";
            // 
            // cbxRow1
            // 
            this.cbxRow1.FormattingEnabled = true;
            this.cbxRow1.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cbxRow1.Location = new System.Drawing.Point(106, 53);
            this.cbxRow1.Name = "cbxRow1";
            this.cbxRow1.Size = new System.Drawing.Size(47, 21);
            this.cbxRow1.TabIndex = 3;
            // 
            // cbxCol1
            // 
            this.cbxCol1.FormattingEnabled = true;
            this.cbxCol1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCol1.Location = new System.Drawing.Point(170, 53);
            this.cbxCol1.Name = "cbxCol1";
            this.cbxCol1.Size = new System.Drawing.Size(47, 21);
            this.cbxCol1.TabIndex = 4;
            // 
            // lblSeat2
            // 
            this.lblSeat2.AutoSize = true;
            this.lblSeat2.Location = new System.Drawing.Point(12, 80);
            this.lblSeat2.Name = "lblSeat2";
            this.lblSeat2.Size = new System.Drawing.Size(74, 13);
            this.lblSeat2.TabIndex = 5;
            this.lblSeat2.Text = "Select Seat 2:";
            // 
            // lblSeat3
            // 
            this.lblSeat3.AutoSize = true;
            this.lblSeat3.Location = new System.Drawing.Point(12, 103);
            this.lblSeat3.Name = "lblSeat3";
            this.lblSeat3.Size = new System.Drawing.Size(74, 13);
            this.lblSeat3.TabIndex = 8;
            this.lblSeat3.Text = "Select Seat 3:";
            // 
            // lblSeat4
            // 
            this.lblSeat4.AutoSize = true;
            this.lblSeat4.Location = new System.Drawing.Point(12, 127);
            this.lblSeat4.Name = "lblSeat4";
            this.lblSeat4.Size = new System.Drawing.Size(74, 13);
            this.lblSeat4.TabIndex = 11;
            this.lblSeat4.Text = "Select Seat 4:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(293, 201);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbxCol2
            // 
            this.cbxCol2.FormattingEnabled = true;
            this.cbxCol2.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCol2.Location = new System.Drawing.Point(170, 77);
            this.cbxCol2.Name = "cbxCol2";
            this.cbxCol2.Size = new System.Drawing.Size(47, 21);
            this.cbxCol2.TabIndex = 16;
            // 
            // cbxRow2
            // 
            this.cbxRow2.FormattingEnabled = true;
            this.cbxRow2.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cbxRow2.Location = new System.Drawing.Point(106, 77);
            this.cbxRow2.Name = "cbxRow2";
            this.cbxRow2.Size = new System.Drawing.Size(47, 21);
            this.cbxRow2.TabIndex = 15;
            // 
            // cbxCol3
            // 
            this.cbxCol3.FormattingEnabled = true;
            this.cbxCol3.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCol3.Location = new System.Drawing.Point(170, 100);
            this.cbxCol3.Name = "cbxCol3";
            this.cbxCol3.Size = new System.Drawing.Size(47, 21);
            this.cbxCol3.TabIndex = 18;
            // 
            // cbxRow3
            // 
            this.cbxRow3.FormattingEnabled = true;
            this.cbxRow3.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cbxRow3.Location = new System.Drawing.Point(106, 100);
            this.cbxRow3.Name = "cbxRow3";
            this.cbxRow3.Size = new System.Drawing.Size(47, 21);
            this.cbxRow3.TabIndex = 17;
            // 
            // cbxCol4
            // 
            this.cbxCol4.FormattingEnabled = true;
            this.cbxCol4.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCol4.Location = new System.Drawing.Point(170, 124);
            this.cbxCol4.Name = "cbxCol4";
            this.cbxCol4.Size = new System.Drawing.Size(47, 21);
            this.cbxCol4.TabIndex = 20;
            // 
            // cbxRow4
            // 
            this.cbxRow4.FormattingEnabled = true;
            this.cbxRow4.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cbxRow4.Location = new System.Drawing.Point(106, 124);
            this.cbxRow4.Name = "cbxRow4";
            this.cbxRow4.Size = new System.Drawing.Size(47, 21);
            this.cbxRow4.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheck1
            // 
            this.btnCheck1.Location = new System.Drawing.Point(223, 53);
            this.btnCheck1.Name = "btnCheck1";
            this.btnCheck1.Size = new System.Drawing.Size(75, 23);
            this.btnCheck1.TabIndex = 22;
            this.btnCheck1.Text = "Check";
            this.btnCheck1.UseVisualStyleBackColor = true;
            this.btnCheck1.Click += new System.EventHandler(this.btnCheck1_Click);
            // 
            // btnCheck2
            // 
            this.btnCheck2.Location = new System.Drawing.Point(223, 77);
            this.btnCheck2.Name = "btnCheck2";
            this.btnCheck2.Size = new System.Drawing.Size(75, 23);
            this.btnCheck2.TabIndex = 23;
            this.btnCheck2.Text = "Check";
            this.btnCheck2.UseVisualStyleBackColor = true;
            this.btnCheck2.Click += new System.EventHandler(this.btnCheck2_Click);
            // 
            // btnCheck3
            // 
            this.btnCheck3.Location = new System.Drawing.Point(223, 100);
            this.btnCheck3.Name = "btnCheck3";
            this.btnCheck3.Size = new System.Drawing.Size(75, 23);
            this.btnCheck3.TabIndex = 24;
            this.btnCheck3.Text = "Check";
            this.btnCheck3.UseVisualStyleBackColor = true;
            this.btnCheck3.Click += new System.EventHandler(this.btnCheck3_Click);
            // 
            // btnCheck4
            // 
            this.btnCheck4.Location = new System.Drawing.Point(223, 122);
            this.btnCheck4.Name = "btnCheck4";
            this.btnCheck4.Size = new System.Drawing.Size(75, 23);
            this.btnCheck4.TabIndex = 25;
            this.btnCheck4.Text = "Check";
            this.btnCheck4.UseVisualStyleBackColor = true;
            this.btnCheck4.Click += new System.EventHandler(this.btnCheck4_Click);
            // 
            // lblAvailable1
            // 
            this.lblAvailable1.AutoSize = true;
            this.lblAvailable1.Location = new System.Drawing.Point(304, 53);
            this.lblAvailable1.Name = "lblAvailable1";
            this.lblAvailable1.Size = new System.Drawing.Size(10, 13);
            this.lblAvailable1.TabIndex = 26;
            this.lblAvailable1.Text = "-";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(305, 36);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(56, 13);
            this.lblAvailability.TabIndex = 27;
            this.lblAvailability.Text = "Availability";
            // 
            // lblAvailable2
            // 
            this.lblAvailable2.AutoSize = true;
            this.lblAvailable2.Location = new System.Drawing.Point(304, 77);
            this.lblAvailable2.Name = "lblAvailable2";
            this.lblAvailable2.Size = new System.Drawing.Size(10, 13);
            this.lblAvailable2.TabIndex = 28;
            this.lblAvailable2.Text = "-";
            // 
            // lblAvailable3
            // 
            this.lblAvailable3.AutoSize = true;
            this.lblAvailable3.Location = new System.Drawing.Point(304, 100);
            this.lblAvailable3.Name = "lblAvailable3";
            this.lblAvailable3.Size = new System.Drawing.Size(10, 13);
            this.lblAvailable3.TabIndex = 29;
            this.lblAvailable3.Text = "-";
            // 
            // lblAvailable4
            // 
            this.lblAvailable4.AutoSize = true;
            this.lblAvailable4.Location = new System.Drawing.Point(304, 122);
            this.lblAvailable4.Name = "lblAvailable4";
            this.lblAvailable4.Size = new System.Drawing.Size(10, 13);
            this.lblAvailable4.TabIndex = 30;
            this.lblAvailable4.Text = "-";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(223, 152);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 31;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(11, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(116, 13);
            this.lblInstructions.TabIndex = 32;
            this.lblInstructions.Text = "Please select 1-4 seats";
            // 
            // FrmSelectSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 236);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.lblAvailable4);
            this.Controls.Add(this.lblAvailable3);
            this.Controls.Add(this.lblAvailable2);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblAvailable1);
            this.Controls.Add(this.btnCheck4);
            this.Controls.Add(this.btnCheck3);
            this.Controls.Add(this.btnCheck2);
            this.Controls.Add(this.btnCheck1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbxCol4);
            this.Controls.Add(this.cbxRow4);
            this.Controls.Add(this.cbxCol3);
            this.Controls.Add(this.cbxRow3);
            this.Controls.Add(this.cbxCol2);
            this.Controls.Add(this.cbxRow2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblSeat4);
            this.Controls.Add(this.lblSeat3);
            this.Controls.Add(this.lblSeat2);
            this.Controls.Add(this.cbxCol1);
            this.Controls.Add(this.cbxRow1);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblSeat1);
            this.Name = "FrmSelectSeats";
            this.Text = "Select Seats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeat1;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.ComboBox cbxRow1;
        private System.Windows.Forms.ComboBox cbxCol1;
        private System.Windows.Forms.Label lblSeat2;
        private System.Windows.Forms.Label lblSeat3;
        private System.Windows.Forms.Label lblSeat4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbxCol2;
        private System.Windows.Forms.ComboBox cbxRow2;
        private System.Windows.Forms.ComboBox cbxCol3;
        private System.Windows.Forms.ComboBox cbxRow3;
        private System.Windows.Forms.ComboBox cbxCol4;
        private System.Windows.Forms.ComboBox cbxRow4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheck1;
        private System.Windows.Forms.Button btnCheck2;
        private System.Windows.Forms.Button btnCheck3;
        private System.Windows.Forms.Button btnCheck4;
        private System.Windows.Forms.Label lblAvailable1;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblAvailable2;
        private System.Windows.Forms.Label lblAvailable3;
        private System.Windows.Forms.Label lblAvailable4;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Label lblInstructions;
    }
}