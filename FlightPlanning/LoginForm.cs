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

            
