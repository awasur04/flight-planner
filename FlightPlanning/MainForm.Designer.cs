namespace FlightPlanning
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.currentFlights = new System.Windows.Forms.TabPage();
            this.createNewTrip = new System.Windows.Forms.TabPage();
            this.welcomeBox = new System.Windows.Forms.GroupBox();
            this.futureTripsBox = new System.Windows.Forms.GroupBox();
            this.pastTripsBox = new System.Windows.Forms.GroupBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.milesLabel = new System.Windows.Forms.Label();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.changeEmailButton = new System.Windows.Forms.Button();
            this.passwordButton = new System.Windows.Forms.Button();
            this.closeAcctButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.welcomeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomeTab);
            this.tabControl1.Controls.Add(this.currentFlights);
            this.tabControl1.Controls.Add(this.createNewTrip);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.pastTripsBox);
            this.welcomeTab.Controls.Add(this.futureTripsBox);
            this.welcomeTab.Controls.Add(this.welcomeBox);
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(927, 594);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "Welcome";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // currentFlights
            // 
            this.currentFlights.Location = new System.Drawing.Point(4, 22);
            this.currentFlights.Name = "currentFlights";
            this.currentFlights.Padding = new System.Windows.Forms.Padding(3);
            this.currentFlights.Size = new System.Drawing.Size(927, 594);
            this.currentFlights.TabIndex = 1;
            this.currentFlights.Text = "Current Trip";
            this.currentFlights.UseVisualStyleBackColor = true;
            // 
            // createNewTrip
            // 
            this.createNewTrip.Location = new System.Drawing.Point(4, 22);
            this.createNewTrip.Name = "createNewTrip";
            this.createNewTrip.Size = new System.Drawing.Size(1391, 594);
            this.createNewTrip.TabIndex = 2;
            this.createNewTrip.Text = "+";
            this.createNewTrip.UseVisualStyleBackColor = true;
            // 
            // welcomeBox
            // 
            this.welcomeBox.Controls.Add(this.logOutButton);
            this.welcomeBox.Controls.Add(this.closeAcctButton);
            this.welcomeBox.Controls.Add(this.passwordButton);
            this.welcomeBox.Controls.Add(this.changeEmailButton);
            this.welcomeBox.Controls.Add(this.loyaltyLabel);
            this.welcomeBox.Controls.Add(this.milesLabel);
            this.welcomeBox.Controls.Add(this.emailLabel);
            this.welcomeBox.Controls.Add(this.welcomeLabel);
            this.welcomeBox.Location = new System.Drawing.Point(6, 6);
            this.welcomeBox.Name = "welcomeBox";
            this.welcomeBox.Size = new System.Drawing.Size(477, 154);
            this.welcomeBox.TabIndex = 0;
            this.welcomeBox.TabStop = false;
            this.welcomeBox.Text = "Account";
            // 
            // futureTripsBox
            // 
            this.futureTripsBox.Location = new System.Drawing.Point(489, 6);
            this.futureTripsBox.Name = "futureTripsBox";
            this.futureTripsBox.Size = new System.Drawing.Size(431, 579);
            this.futureTripsBox.TabIndex = 1;
            this.futureTripsBox.TabStop = false;
            this.futureTripsBox.Text = "Future Trips";
            // 
            // pastTripsBox
            // 
            this.pastTripsBox.Location = new System.Drawing.Point(6, 166);
            this.pastTripsBox.Name = "pastTripsBox";
            this.pastTripsBox.Size = new System.Drawing.Size(477, 419);
            this.pastTripsBox.TabIndex = 2;
            this.pastTripsBox.TabStop = false;
            this.pastTripsBox.Text = "Previous Trips";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(6, 16);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(107, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(8, 50);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 16);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLabel.Location = new System.Drawing.Point(8, 66);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(42, 16);
            this.milesLabel.TabIndex = 2;
            this.milesLabel.Text = "Miles:";
            // 
            // loyaltyLabel
            // 
            this.loyaltyLabel.AutoSize = true;
            this.loyaltyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loyaltyLabel.Location = new System.Drawing.Point(8, 82);
            this.loyaltyLabel.Name = "loyaltyLabel";
            this.loyaltyLabel.Size = new System.Drawing.Size(89, 16);
            this.loyaltyLabel.TabIndex = 3;
            this.loyaltyLabel.Text = "Loyalty Level:";
            // 
            // changeEmailButton
            // 
            this.changeEmailButton.Location = new System.Drawing.Point(11, 114);
            this.changeEmailButton.Name = "changeEmailButton";
            this.changeEmailButton.Size = new System.Drawing.Size(102, 23);
            this.changeEmailButton.TabIndex = 4;
            this.changeEmailButton.Text = "Change Email";
            this.changeEmailButton.UseVisualStyleBackColor = true;
            this.changeEmailButton.Click += new System.EventHandler(this.changeEmailButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(119, 114);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(103, 23);
            this.passwordButton.TabIndex = 5;
            this.passwordButton.Text = "Change Password";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // closeAcctButton
            // 
            this.closeAcctButton.Location = new System.Drawing.Point(228, 114);
            this.closeAcctButton.Name = "closeAcctButton";
            this.closeAcctButton.Size = new System.Drawing.Size(106, 23);
            this.closeAcctButton.TabIndex = 6;
            this.closeAcctButton.Text = "Close Account";
            this.closeAcctButton.UseVisualStyleBackColor = true;
            this.closeAcctButton.Click += new System.EventHandler(this.closeAcctButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(340, 114);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(113, 23);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 622);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Flight Planner";
            this.tabControl1.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeBox.ResumeLayout(false);
            this.welcomeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.GroupBox pastTripsBox;
        private System.Windows.Forms.GroupBox futureTripsBox;
        private System.Windows.Forms.GroupBox welcomeBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button closeAcctButton;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.Button changeEmailButton;
        private System.Windows.Forms.Label loyaltyLabel;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TabPage currentFlights;
        private System.Windows.Forms.TabPage createNewTrip;
    }
}