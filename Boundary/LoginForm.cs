using Control;
using GUIForJTS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jaguars_Tech_Support.Boundary
{
    internal class LoginForm : Form1
    {
        private Panel panel1;
        private Label label1;
        private CustomTextBox SignInOutLine;
        private RoundedButton signInButton;
        private Label label2;
        private Label label3;
        private Label label4;
        protected CustomTextBox emailTextBox;
        private Label logoutMessage;
        protected CustomTextBox passwordTextBox;

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            SignInOutLine = new CustomTextBox();
            signInButton = new RoundedButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            emailTextBox = new CustomTextBox();
            passwordTextBox = new CustomTextBox();
            logoutMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 65);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 45);
            label1.TabIndex = 0;
            label1.Text = "Jaguars' Tech Support";
            // 
            // SignInOutLine
            // 
            SignInOutLine.Anchor = AnchorStyles.None;
            SignInOutLine.BackColor = Color.White;
            SignInOutLine.BorderColor = Color.Black;
            SignInOutLine.BorderFocusColor = Color.HotPink;
            SignInOutLine.BorderRadius = 15;
            SignInOutLine.BorderSize = 1;
            SignInOutLine.Enabled = false;
            SignInOutLine.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            SignInOutLine.ForeColor = Color.Transparent;
            SignInOutLine.Location = new Point(411, 237);
            SignInOutLine.Multiline = true;
            SignInOutLine.Name = "SignInOutLine";
            SignInOutLine.Padding = new Padding(10, 7, 10, 7);
            SignInOutLine.PasswordChar = false;
            SignInOutLine.Size = new Size(372, 424);
            SignInOutLine.TabIndex = 4;
            SignInOutLine.Texts = "";
            SignInOutLine.UnderlinedSytle = false;
            // 
            // signInButton
            // 
            signInButton.Anchor = AnchorStyles.None;
            signInButton.BackColor = Color.Black;
            signInButton.BackgroundColor = Color.Black;
            signInButton.BorderColor = Color.Black;
            signInButton.BorderRadius = 40;
            signInButton.BorderSize = 0;
            signInButton.FlatAppearance.BorderSize = 0;
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signInButton.ForeColor = Color.Transparent;
            signInButton.Location = new Point(482, 555);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(230, 40);
            signInButton.TabIndex = 7;
            signInButton.Text = "Sign In";
            signInButton.TextColor = Color.Transparent;
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += roundedButton1_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(557, 282);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 8;
            label2.Text = "Sign In";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(461, 355);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(461, 437);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.BorderColor = Color.Black;
            emailTextBox.BorderFocusColor = SystemColors.ActiveBorder;
            emailTextBox.BorderRadius = 15;
            emailTextBox.BorderSize = 1;
            emailTextBox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.Black;
            emailTextBox.Location = new Point(461, 380);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Multiline = false;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Padding = new Padding(11, 9, 11, 9);
            emailTextBox.PasswordChar = false;
            emailTextBox.Size = new Size(278, 40);
            emailTextBox.TabIndex = 11;
            emailTextBox.Texts = "";
            emailTextBox.UnderlinedSytle = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderColor = Color.Black;
            passwordTextBox.BorderFocusColor = SystemColors.ActiveBorder;
            passwordTextBox.BorderRadius = 15;
            passwordTextBox.BorderSize = 1;
            passwordTextBox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(461, 462);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Multiline = false;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Padding = new Padding(11, 9, 11, 9);
            passwordTextBox.PasswordChar = true;
            passwordTextBox.Size = new Size(278, 40);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.Texts = "";
            passwordTextBox.UnderlinedSytle = false;
            // 
            // logoutMessage
            // 
            logoutMessage.AutoSize = true;
            logoutMessage.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutMessage.Location = new Point(540, 177);
            logoutMessage.Name = "logoutMessage";
            logoutMessage.Size = new Size(133, 21);
            logoutMessage.TabIndex = 13;
            logoutMessage.Text = "Logout Successful.";
            logoutMessage.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1184, 861);
            Controls.Add(logoutMessage);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(signInButton);
            Controls.Add(SignInOutLine);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += LoginForm_Closed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        public void Submit()
        {
            string email = emailTextBox.Texts;
            string password = passwordTextBox.Texts;
            LoginControl.Submit(email, password);

        }
        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            Submit();
        }

        private void LoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            // Check if there are any open forms
            if (Application.OpenForms.Count == 0)
            {
                // All forms have been closed, so exit the application
                Application.Exit();
            }
        }

        public void DisplayLogout()
        {
            logoutMessage.Visible = true;
        }
    }
}
