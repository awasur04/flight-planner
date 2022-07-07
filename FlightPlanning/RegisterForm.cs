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
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            CreationStatus status = db.CreateUser("test", "test", "test");
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

            MessageBox.Show(message);
        }
    }
}
