﻿namespace BloomFeildHotel
{
    partial class formReception
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSavedGuests = new System.Windows.Forms.Button();
            this.btnViewRoomChart = new System.Windows.Forms.Button();
            this.btnSearchForReservation = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.lblReceptionMenu = new System.Windows.Forms.Label();
            this.lblHiReceptionMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnViewGuests = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(610, 683);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(742, 88);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSavedGuests
            // 
            this.btnSavedGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavedGuests.Location = new System.Drawing.Point(1112, 475);
            this.btnSavedGuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavedGuests.Name = "btnSavedGuests";
            this.btnSavedGuests.Size = new System.Drawing.Size(242, 160);
            this.btnSavedGuests.TabIndex = 18;
            this.btnSavedGuests.Text = "Saved Guests";
            this.btnSavedGuests.UseVisualStyleBackColor = true;
            // 
            // btnViewRoomChart
            // 
            this.btnViewRoomChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoomChart.Location = new System.Drawing.Point(1112, 306);
            this.btnViewRoomChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewRoomChart.Name = "btnViewRoomChart";
            this.btnViewRoomChart.Size = new System.Drawing.Size(242, 160);
            this.btnViewRoomChart.TabIndex = 17;
            this.btnViewRoomChart.Text = "View Room Bookings";
            this.btnViewRoomChart.UseVisualStyleBackColor = true;
            this.btnViewRoomChart.Click += new System.EventHandler(this.BtnViewRoomChart_Click);
            // 
            // btnSearchForReservation
            // 
            this.btnSearchForReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForReservation.Location = new System.Drawing.Point(861, 475);
            this.btnSearchForReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchForReservation.Name = "btnSearchForReservation";
            this.btnSearchForReservation.Size = new System.Drawing.Size(242, 160);
            this.btnSearchForReservation.TabIndex = 15;
            this.btnSearchForReservation.Text = "Search For Reservation";
            this.btnSearchForReservation.UseVisualStyleBackColor = true;
            this.btnSearchForReservation.Click += new System.EventHandler(this.btnSearchForReservation_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(861, 306);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(242, 160);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View Reservations";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(610, 475);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(242, 160);
            this.btnCheckIn.TabIndex = 12;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.Location = new System.Drawing.Point(610, 306);
            this.btnCreateReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(242, 160);
            this.btnCreateReservation.TabIndex = 1;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.BtnCreateReservation_Click);
            // 
            // lblReceptionMenu
            // 
            this.lblReceptionMenu.AutoSize = true;
            this.lblReceptionMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionMenu.Location = new System.Drawing.Point(770, 180);
            this.lblReceptionMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionMenu.Name = "lblReceptionMenu";
            this.lblReceptionMenu.Size = new System.Drawing.Size(410, 61);
            this.lblReceptionMenu.TabIndex = 10;
            this.lblReceptionMenu.Text = "Reception Menu";
            // 
            // lblHiReceptionMenu
            // 
            this.lblHiReceptionMenu.AutoSize = true;
            this.lblHiReceptionMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiReceptionMenu.ForeColor = System.Drawing.Color.White;
            this.lblHiReceptionMenu.Location = new System.Drawing.Point(15, 32);
            this.lblHiReceptionMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHiReceptionMenu.Name = "lblHiReceptionMenu";
            this.lblHiReceptionMenu.Size = new System.Drawing.Size(92, 61);
            this.lblHiReceptionMenu.TabIndex = 0;
            this.lblHiReceptionMenu.Text = "Hi ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHiReceptionMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 105);
            this.panel1.TabIndex = 20;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(360, 475);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(242, 160);
            this.btnChangePassword.TabIndex = 21;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnViewGuests
            // 
            this.btnViewGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGuests.Location = new System.Drawing.Point(360, 306);
            this.btnViewGuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewGuests.Name = "btnViewGuests";
            this.btnViewGuests.Size = new System.Drawing.Size(242, 160);
            this.btnViewGuests.TabIndex = 22;
            this.btnViewGuests.Text = "View Guests";
            this.btnViewGuests.UseVisualStyleBackColor = true;
            this.btnViewGuests.Click += new System.EventHandler(this.btnViewGuests_Click);
            // 
            // formReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1916, 974);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewGuests);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSavedGuests);
            this.Controls.Add(this.btnViewRoomChart);
            this.Controls.Add(this.btnSearchForReservation);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.lblReceptionMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formReception";
            this.Text = "Reception";
            this.Load += new System.EventHandler(this.FormReception_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSavedGuests;
        private System.Windows.Forms.Button btnViewRoomChart;
        private System.Windows.Forms.Button btnSearchForReservation;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Label lblReceptionMenu;
        private System.Windows.Forms.Label lblHiReceptionMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnViewGuests;
    }
}