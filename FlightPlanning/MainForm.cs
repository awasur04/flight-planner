using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FlightPlanning.Models;
using FlightPlanning.Logic;

namespace FlightPlanning.UI
{
    public partial class MainForm : Form
    {
        private const int SPACE_BETWEEN_FLIGHTS = 84;

        private Database db;
        private User currentUser;
        private UtilityForm uf;

        private List<Panel> futureFlights;
        private bool selected = false;
        public MainForm(Database database)
        {
            InitializeComponent();
            db = database;
            currentUser = database.loggedInUser;
            futureFlights = new List<Panel>();

            SetUpAccountGroup();

            Aircraft testAircraft = new Aircraft("YES", "YES", "YES", 33, new DateTimeOffset(DateTime.Now), 6, "sure");
            Flight testFlight = new Flight(44, "15h", "YES", "YES", "YES", "YES", testAircraft, "YES", new DateTimeOffset(DateTime.Now), "YES", "YES", new DateTimeOffset(DateTime.Now), "YES");

            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);
            AddFutureFlight(testFlight);

        }

        #region Event Listeners
        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            uf = new UtilityForm();
            currentUser = uf.CompleteOperation(currentUser, db, this, UtilityOption.CHANGE_EMAIL);
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            uf = new UtilityForm();
            currentUser = uf.CompleteOperation(currentUser, db, this, UtilityOption.CHANGE_PASSWORD);
        }

        private void closeAcctButton_Click(object sender, EventArgs e)
        {
            uf = new UtilityForm();
            currentUser = uf.CompleteOperation(currentUser, db, this, UtilityOption.CLOSE_ACCOUNT);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            bool logOutComplete = db.UpdateUser(currentUser);

            if (logOutComplete)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to log out, please try again.");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.UpdateUser(currentUser);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            selected = !selected;
            
            if (selected)
            {
                templatePanel.BackColor = Color.LightBlue;
            }
            else
            {
                templatePanel.BackColor = SystemColors.Control;
            }
        }
        #endregion

        #region UI Utilities
        public void SetUpAccountGroup()
        {
            welcomeLabel.Text = "Welcome, " + currentUser.Name + "!";
            emailLabel.Text = "Email: " + currentUser.Email;
            milesLabel.Text = "Miles: " + currentUser.Miles;
            loyaltyLabel.Text = "Loyalty Level: " + currentUser.GetLoyaltyLevel();
        }

        public void AddFutureFlight(Flight flight)
        {
            int flightCount = futureFlights.Count;

            Panel newPanel = CreateFlightPanel(flight);
            newPanel.BackColor = System.Drawing.SystemColors.Control;
            newPanel.Location = new System.Drawing.Point(3, (4 + (flightCount * SPACE_BETWEEN_FLIGHTS)));
            newPanel.Size = new System.Drawing.Size(394, 78);
            newPanel.Visible = true;
            newPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);


            futureFlights.Add(newPanel);
            futureFlightsContainer.Controls.Add(newPanel);
        }

        public Panel CreateFlightPanel(Flight flight)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Panel newPanel = new Panel();


            //MAIN PANEL CONTROLS
            //LABELS
            Label seatL = new Label();
            seatL.AutoSize = true;
            seatL.Location = new System.Drawing.Point(10, 5);
            seatL.Size = new System.Drawing.Size(55, 13);
            seatL.Text = "Seat: " + flight.Seat;
            seatL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(seatL);

            Label dateL = new Label();
            dateL.Location = new System.Drawing.Point(96, 5);
            dateL.Size = new System.Drawing.Size(167, 13);
            dateL.Text = "From: 12/12/2012 -> 12/24/2012";
            dateL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(dateL);

            Label statusL = new Label();
            statusL.Location = new System.Drawing.Point(288, 5);
            statusL.Size = new System.Drawing.Size(94, 13);
            statusL.Text = "Status: " + flight.Status;
            statusL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(statusL);

            Label durationL = new Label();
            durationL.Location = new System.Drawing.Point(172, 62);
            durationL.Size = new System.Drawing.Size(51, 13);
            durationL.Text = "12h 55m";
            durationL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(durationL);


            //IMAGES
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox.Location = new System.Drawing.Point(175, 23);
            pictureBox.Size = new System.Drawing.Size(45, 39);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(pictureBox);


            //GROUPBOXS
            GroupBox arrivalBox = CreateFlightGroupBox("Arrival Info", "Dallas / Ft. Worth", "5", "3:10 CST");
            arrivalBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(arrivalBox);
            arrivalBox.Location = new System.Drawing.Point(238, 21);

            GroupBox departureBox = CreateFlightGroupBox("Departure Info", "Leonardo", "2", "10:10 CET");
            departureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            newPanel.Controls.Add(departureBox);
            departureBox.Location = new System.Drawing.Point(4, 21);
            return newPanel;
        }

        public GroupBox CreateFlightGroupBox(string title, string airportName, string gate, string time)
        {
            GroupBox newBox = new GroupBox();
            newBox.Size = new System.Drawing.Size(153, 54);
            newBox.Text = title;

            //Airport Name
            Label arprtName = new Label();
            arprtName.Location = new System.Drawing.Point(8, 12);
            arprtName.Size = new System.Drawing.Size(124, 13);
            arprtName.Text = airportName;

            //Gate
            Label gateL = new Label();
            gateL.Location = new System.Drawing.Point(8, 38);
            gateL.Size = new System.Drawing.Size(42, 13);
            gateL.Text = "Gate: " + gate;

            //Time
            Label timeL = new Label();
            timeL.Location = new System.Drawing.Point(8, 25);
            timeL.Size = new System.Drawing.Size(66, 13);
            timeL.Text = time;

            newBox.Controls.Add(arprtName);
            newBox.Controls.Add(gateL);
            newBox.Controls.Add(timeL);

            return newBox;
        }

        #endregion
    }
}
