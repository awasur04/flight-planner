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
    public partial class UtilityForm : Form
    {
        User currentUser;
        Database db;
        MainForm mainForm;
        public UtilityForm()
        {
            InitializeComponent();
        }

        #region Event Listeners
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeAccountButton_Click(object sender, EventArgs e)
        {
            if (PasswordHash.VerifyInputPassword(closeAccountPasswordTextBox.Text, currentUser.password))
            {
                db.DeleteUser(currentUser);

                DialogResult dg = MessageBox.Show("Account deleted, returning to log in screen.");

                if (dg == DialogResult.OK)
                {
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    mainForm.Close();
                    loginForm.FormClosed += (s, args) => this.Close();
                    loginForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Password is incorrect.");
            }
        }

        //Change email
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string message = "";

            if (PasswordHash.VerifyInputPassword(passwordTextBox.Text, currentUser.password))
            {
                if (InputValidation.Email(emailTextBox1.Text))
                {
                    if (emailTextBox1.Text == emailTextBox2.Text)
                    {
                        emailTextBox1.ForeColor = Color.Black;
                        emailTextBox2.ForeColor = Color.Black;
                        currentUser.email = emailTextBox1.Text;

                        DialogResult dg = MessageBox.Show("Email changed successfully");

                        if (dg == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        message = "Email address doesnt match";
                    }  
                }
                else
                {
                    message = "Please enter a valid email address.";
                }
            }
            else
            {
                message = "Incorrect password";
            }

            if (message != "")
            {
                if (message.Contains("address"))
                {
                    emailTextBox1.ForeColor = Color.Red;
                    emailTextBox2.ForeColor = Color.Red;
                }

                MessageBox.Show(message);
            }
        }

        private void passwordConfirmButton_Click(object sender, EventArgs e)
        {
            string message = "";
            if (PasswordHash.VerifyInputPassword(currentPasswordTextBox.Text, currentUser.password))
            {
                if (newPasswordTextBox1.Text == newPasswordTextBox2.Text)
                {
                    if (InputValidation.Password(newPasswordTextBox1.Text))
                    {
                        currentUser.password = PasswordHash.GetHashedPassword(newPasswordTextBox1.Text);

                        DialogResult dg = MessageBox.Show("Password changed successfully");

                        if (dg == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        message = "Password does not meet requirements";
                    }
                }
                else
                {
                    message = "Passwords do not match";
                }
            }
            else
            {
                message = "Incorrect password";
            }

            if (message != "")
            {
                MessageBox.Show(message);
            }
        }
        #endregion


        #region Operations
        public User CompleteOperation(User user, Database db, MainForm mf, UtilityOption desiredOption)
        {
            currentUser = user;
            this.db = db;
            mainForm = mf;

            switch (desiredOption)
            {
                case UtilityOption.CHANGE_EMAIL:
                    ToggleVisisbleOption(true, false, false);
                    break;

                case UtilityOption.CHANGE_PASSWORD:
                    ToggleVisisbleOption(false, true, false);
                    break;

                case UtilityOption.CLOSE_ACCOUNT:
                    ToggleVisisbleOption(false, false, true);
                    break;
            }
            return currentUser;
        }

        public void ToggleVisisbleOption(bool email, bool password, bool closeAccount)
        {
            emailChangeBox.Visible = email;
            changePasswordBox.Visible = password;
            closeAccountBox.Visible = closeAccount;
            this.ShowDialog();
        }

        #endregion
    }
}
