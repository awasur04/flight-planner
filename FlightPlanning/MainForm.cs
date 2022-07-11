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
    }
}
