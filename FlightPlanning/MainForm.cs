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

namespace FlightPlanning
{
    public partial class MainForm : Form
    {
        private Database db;
        private User currentUser;
        private UtilityForm uf;
        public MainForm(Database database)
        {
            InitializeComponent();
            db = database;
            currentUser = database.loggedInUser;

            SetUpAccountGroup();
        }

        public void SetUpAccountGroup()
        {
            welcomeLabel.Text = "Welcome, " + currentUser.name + "!";
            emailLabel.Text = "Email: " + currentUser.email;
            milesLabel.Text = "Miles: " + currentUser.miles;
            loyaltyLabel.Text = "Loyalty Level: " + currentUser.GetLoyaltyLevel();
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            uf = new UtilityForm();
            currentUser = uf.CompleteOperation(currentUser, UtilityOption.CHANGE_EMAIL);
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            uf = new UtilityForm();
            currentUser = uf.CompleteOperation(currentUser, UtilityOption.CHANGE_PASSWORD);
        }

        private void closeAcctButton_Click(object sender, EventArgs e)
        {
            uf = new UtilityForm();
            currentUser = uf.CompleteOperation(currentUser, UtilityOption.CLOSE_ACCOUNT);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
