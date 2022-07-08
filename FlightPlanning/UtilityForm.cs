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
    public partial class UtilityForm : Form
    {
        public UtilityForm()
        {
            InitializeComponent();
        }

        #region Event Listeners
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Operations
        public User CompleteOperation(User user, UtilityOption desiredOption)
        {
            User currentUser = user;
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
