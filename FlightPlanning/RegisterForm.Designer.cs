namespace FlightPlanning.UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.passwordRegisterLabel = new System.Windows.Forms.Label();
            this.nameRegisterLabel = new System.Windows.Forms.Label();
            this.passwordRegisterTextBox = new System.Windows.Forms.TextBox();
            this.nameRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailRegisterLabel = new System.Windows.Forms.Label();
            this.emailRegisterTextBox1 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordRegisterLabel
            // 
            this.passwordRegisterLabel.AutoSize = true;
            this.passwordRegisterLabel.Location = new System.Drawing.Point(74, 131);
            this.passwordRegisterLabel.Name = "passwordRegisterLabel";
            this.passwordRegisterLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordRegisterLabel.TabIndex = 8;
            this.passwordRegisterLabel.Text = "Password:";
            // 
            // nameRegisterLabel
            // 
            this.nameRegisterLabel.AutoSize = true;
            this.nameRegisterLabel.Location = new System.Drawing.Point(75, 53);
            this.nameRegisterLabel.Name = "nameRegisterLabel";
            this.nameRegisterLabel.Size = new System.Drawing.Size(38, 13);
            this.nameRegisterLabel.TabIndex = 7;
            this.nameRegisterLabel.Text = "Name:";
            // 
            // passwordRegisterTextBox
            // 
            this.passwordRegisterTextBox.Location = new System.Drawing.Point(77, 147);
            this.passwordRegisterTextBox.Name = "passwordRegisterTextBox";
            this.passwordRegisterTextBox.Size = new System.Drawing.Size(204, 20);
            this.passwordRegisterTextBox.TabIndex = 6;
            this.passwordRegisterTextBox.UseSystemPasswordChar = true;
            // 
            // nameRegisterTextBox
            // 
            this.nameRegisterTextBox.Location = new System.Drawing.Point(78, 69);
            this.nameRegisterTextBox.Name = "nameRegisterTextBox";
            this.nameRegisterTextBox.Size = new System.Drawing.Size(204, 20);
            this.nameRegisterTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Register for an account.";
            // 
            // emailRegisterLabel
            // 
            this.emailRegisterLabel.AutoSize = true;
            this.emailRegisterLabel.Location = new System.Drawing.Point(75, 92);
            this.emailRegisterLabel.Name = "emailRegisterLabel";
            this.emailRegisterLabel.Size = new System.Drawing.Size(35, 13);
            this.emailRegisterLabel.TabIndex = 11;
            this.emailRegisterLabel.Text = "Email:";
            // 
            // emailRegisterTextBox1
            // 
            this.emailRegisterTextBox1.Location = new System.Drawing.Point(78, 108);
            this.emailRegisterTextBox1.Name = "emailRegisterTextBox1";
            this.emailRegisterTextBox1.Size = new System.Drawing.Size(204, 20);
            this.emailRegisterTextBox1.TabIndex = 10;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(142, 231);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.Location = new System.Drawing.Point(142, 260);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(75, 23);
            this.backToLoginButton.TabIndex = 13;
            this.backToLoginButton.Text = "Back";
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(77, 186);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(204, 20);
            this.confirmPasswordTextBox.TabIndex = 14;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailRegisterLabel);
            this.Controls.Add(this.emailRegisterTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordRegisterLabel);
            this.Controls.Add(this.nameRegisterLabel);
            this.Controls.Add(this.passwordRegisterTextBox);
            this.Controls.Add(this.nameRegisterTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordRegisterLabel;
        private System.Windows.Forms.Label nameRegisterLabel;
        private System.Windows.Forms.TextBox passwordRegisterTextBox;
        private System.Windows.Forms.TextBox nameRegisterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailRegisterLabel;
        private System.Windows.Forms.TextBox emailRegisterTextBox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
    }
}