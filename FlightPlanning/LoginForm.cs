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
    public partial class LoginForm : Form
    {
        private bool showPassword = false;
        private Validate validate;
        private Database db;
        
        public LoginForm()
        {
            InitializeComponent();
            validate = new Validate();
            db = new Database();
        }

        #region Button Event Handlers
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void showPasswordImage_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                showPasswordImage.Image = Image.FromFile(Application.StartupPath + "\\resources\\images\\password-show.png");
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                showPasswordImage.Image = Image.FromFile(Application.StartupPath + "\\resources\\images\\password-hide.png");
            }
        }
        #endregion

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(!validate.Email(emailTextBox.Text.ToString().Trim()))
            {
                emailTextBox.ForeColor = Color.Red;
                MessageBox.Show("Invalid email address");
                return;
            }

            emailTextBox.ForeColor = Color.Black;

            if(db.Login(emailTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Logged in");
            }
            else
            {
                MessageBox.Show("Invalid login");
            }

            
        }
    }
}
