namespace FlightPlanning.UI
{
    partial class UtilityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilityForm));
            this.emailChangeBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.emailTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changePasswordBox = new System.Windows.Forms.GroupBox();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton2 = new System.Windows.Forms.Button();
            this.passwordConfirmButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeAccountBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.closeAccountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelButton3 = new System.Windows.Forms.Button();
            this.closeAccountButton = new System.Windows.Forms.Button();
            this.emailChangeBox.SuspendLayout();
            this.changePasswordBox.SuspendLayout();
            this.closeAccountBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailChangeBox
            // 
            this.emailChangeBox.Controls.Add(this.passwordTextBox);
            this.emailChangeBox.Controls.Add(this.label3);
            this.emailChangeBox.Controls.Add(this.cancelButton);
            this.emailChangeBox.Controls.Add(this.confirmButton);
            this.emailChangeBox.Controls.Add(this.emailTextBox2);
            this.emailChangeBox.Controls.Add(this.label2);
            this.emailChangeBox.Controls.Add(this.emailTextBox1);
            this.emailChangeBox.Controls.Add(this.label1);
            this.emailChangeBox.Location = new System.Drawing.Point(10, 10);
            this.emailChangeBox.Name = "emailChangeBox";
            this.emailChangeBox.Size = new System.Drawing.Size(399, 316);
            this.emailChangeBox.TabIndex = 0;
            this.emailChangeBox.TabStop = false;
            this.emailChangeBox.Text = "Change Email";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 183);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(178, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(142, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(142, 209);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.Location = new System.Drawing.Point(97, 125);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.Size = new System.Drawing.Size(178, 20);
            this.emailTextBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm New Email:";
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.Location = new System.Drawing.Point(97, 86);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(178, 20);
            this.emailTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Email:";
            // 
            // changePasswordBox
            // 
            this.changePasswordBox.Controls.Add(this.currentPasswordTextBox);
            this.changePasswordBox.Controls.Add(this.label4);
            this.changePasswordBox.Controls.Add(this.cancelButton2);
            this.changePasswordBox.Controls.Add(this.passwordConfirmButton);
            this.changePasswordBox.Controls.Add(this.newPasswordTextBox2);
            this.changePasswordBox.Controls.Add(this.label5);
            this.changePasswordBox.Controls.Add(this.newPasswordTextBox1);
            this.changePasswordBox.Controls.Add(this.label6);
            this.changePasswordBox.Location = new System.Drawing.Point(10, 10);
            this.changePasswordBox.Name = "changePasswordBox";
            this.changePasswordBox.Size = new System.Drawing.Size(399, 316);
            this.changePasswordBox.TabIndex = 8;
            this.changePasswordBox.TabStop = false;
            this.changePasswordBox.Text = "Change Password";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Location = new System.Drawing.Point(97, 183);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(178, 20);
            this.currentPasswordTextBox.TabIndex = 3;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Password:";
            // 
            // cancelButton2
            // 
            this.cancelButton2.Location = new System.Drawing.Point(142, 238);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.Size = new System.Drawing.Size(75, 23);
            this.cancelButton2.TabIndex = 5;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.UseVisualStyleBackColor = true;
            this.cancelButton2.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordConfirmButton
            // 
            this.passwordConfirmButton.Location = new System.Drawing.Point(142, 209);
            this.passwordConfirmButton.Name = "passwordConfirmButton";
            this.passwordConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.passwordConfirmButton.TabIndex = 4;
            this.passwordConfirmButton.Text = "Confirm";
            this.passwordConfirmButton.UseVisualStyleBackColor = true;
            this.passwordConfirmButton.Click += new System.EventHandler(this.passwordConfirmButton_Click);
            // 
            // newPasswordTextBox2
            // 
            this.newPasswordTextBox2.Location = new System.Drawing.Point(97, 125);
            this.newPasswordTextBox2.Name = "newPasswordTextBox2";
            this.newPasswordTextBox2.Size = new System.Drawing.Size(178, 20);
            this.newPasswordTextBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirm New Password:";
            // 
            // newPasswordTextBox1
            // 
            this.newPasswordTextBox1.Location = new System.Drawing.Point(97, 86);
            this.newPasswordTextBox1.Name = "newPasswordTextBox1";
            this.newPasswordTextBox1.Size = new System.Drawing.Size(178, 20);
            this.newPasswordTextBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Password:";
            // 
            // closeAccountBox
            // 
            this.closeAccountBox.Controls.Add(this.label10);
            this.closeAccountBox.Controls.Add(this.label9);
            this.closeAccountBox.Controls.Add(this.label8);
            this.closeAccountBox.Controls.Add(this.closeAccountPasswordTextBox);
            this.closeAccountBox.Controls.Add(this.label7);
            this.closeAccountBox.Controls.Add(this.cancelButton3);
            this.closeAccountBox.Controls.Add(this.closeAccountButton);
            this.closeAccountBox.Location = new System.Drawing.Point(10, 10);
            this.closeAccountBox.Name = "closeAccountBox";
            this.closeAccountBox.Size = new System.Drawing.Size(399, 316);
            this.closeAccountBox.TabIndex = 9;
            this.closeAccountBox.TabStop = false;
            this.closeAccountBox.Text = "Close Account";
            this.closeAccountBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Enter your password to confirm.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "This action is PERMENANT and you will lose all loyalty rewards and milage.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Are you sure you want to DELETE your account?";
            // 
            // closeAccountPasswordTextBox
            // 
            this.closeAccountPasswordTextBox.Location = new System.Drawing.Point(97, 183);
            this.closeAccountPasswordTextBox.Name = "closeAccountPasswordTextBox";
            this.closeAccountPasswordTextBox.Size = new System.Drawing.Size(178, 20);
            this.closeAccountPasswordTextBox.TabIndex = 1;
            this.closeAccountPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password:";
            // 
            // cancelButton3
            // 
            this.cancelButton3.Location = new System.Drawing.Point(142, 238);
            this.cancelButton3.Name = "cancelButton3";
            this.cancelButton3.Size = new System.Drawing.Size(75, 23);
            this.cancelButton3.TabIndex = 3;
            this.cancelButton3.Text = "Cancel";
            this.cancelButton3.UseVisualStyleBackColor = true;
            this.cancelButton3.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // closeAccountButton
            // 
            this.closeAccountButton.Location = new System.Drawing.Point(142, 209);
            this.closeAccountButton.Name = "closeAccountButton";
            this.closeAccountButton.Size = new System.Drawing.Size(75, 23);
            this.closeAccountButton.TabIndex = 2;
            this.closeAccountButton.Text = "Confirm";
            this.closeAccountButton.UseVisualStyleBackColor = true;
            this.closeAccountButton.Click += new System.EventHandler(this.closeAccountButton_Click);
            // 
            // UtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 337);
            this.Controls.Add(this.closeAccountBox);
            this.Controls.Add(this.changePasswordBox);
            this.Controls.Add(this.emailChangeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UtilityForm";
            this.Text = "Account Management";
            this.emailChangeBox.ResumeLayout(false);
            this.emailChangeBox.PerformLayout();
            this.changePasswordBox.ResumeLayout(false);
            this.changePasswordBox.PerformLayout();
            this.closeAccountBox.ResumeLayout(false);
            this.closeAccountBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox emailChangeBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox emailTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox changePasswordBox;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton2;
        private System.Windows.Forms.Button passwordConfirmButton;
        private System.Windows.Forms.TextBox newPasswordTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPasswordTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox closeAccountBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox closeAccountPasswordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelButton3;
        private System.Windows.Forms.Button closeAccountButton;
    }
}