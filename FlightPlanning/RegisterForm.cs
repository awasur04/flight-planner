using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightPlanning.Logic;
using FlightPlanning.Models;

namespace FlightPlanning.UI
{
    public partial class RegisterForm : Form
    {
        private Database db;
        private Validate validate;
        private TextBox[] registerTextBoxes;
        public RegisterForm()
        {
            InitializeComponent();

            db = new Database();
            validate = new Validate();

            registerTextBoxes = new TextBox[] { emailRegisterTextBox1, passwordRegisterTextBox, nameRegisterTextBox };
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            string email = emailRegisterTextBox1.Text.ToString();
            string password = passwordRegisterTextBox.Text.ToString();
            string name = nameRegisterTextBox.Text.ToString();


            bool[] validInput = new bool[] { validate.Email(email), validate.Password(password), validate.Name(name) };

            for (int i = 0; i < registerTextBoxes.Length; i++)
            {
                if (validInput[i])
                {
                    registerTextBoxes[i].ForeColor = Color.Black;
                }
                else
                {
                    registerTextBoxes[i].ForeColor = Color.Red;
                }
            }

            if (!validInput[0] || !validInput[1] || !validInput[2])
            {
                MessageBox.Show("Please correct the highlighted fields.");
                return;
            }
            
            if (password != confirmPasswordTextBox.Text.ToString())
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            
            CreationStatus status = db.CreateUser(email, password, name);
            string message = "";

            switch (status)
            {
                case CreationStatus.SUCCESS:
                    message = "Account Created!";
                    break;

                case CreationStatus.FAILURE:
                    message = "Unable to make account";
                    break;

                case CreationStatus.ACCT_ALREADY_EXISTS:
                    message = "Email address is already assigned to an account, did you mean to login?";
                    break;
            }

            DialogResult dg = MessageBox.Show(message);
            if (dg == DialogResult.OK && status == CreationStatus.SUCCESS)
            {
                this.Close();
            }
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
