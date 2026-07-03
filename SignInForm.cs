using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C__Project
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username_SignIn = txtUserName_SignIn.Text.Trim();
            string password_SignIn = txtPassword_SignIn.Text.Trim();

            if (username_SignIn == "" || password_SignIn == "")
            {
                MessageBox.Show(
                "Please fill all fields.",
                "Incomplete Fields",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
                return;
            }

            string filePath = Path.Combine(Application.StartupPath, "users.txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 2 && parts[0] != username_SignIn)
                {
                    MessageBox.Show(
                    "You've Entered An Unregistered Username.\n\n Enter a Correct Username or Sign Up.",
                    "Invalid Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }

                else if (parts.Length == 2 && parts[0] == username_SignIn && parts[1] != password_SignIn)
                {
                    MessageBox.Show(
                    "Wrong Password.",
                    "Login Unsuccessful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }

                else if (parts.Length == 2 && parts[0] == username_SignIn && parts[1] == password_SignIn)
                {
                    DialogResult res = MessageBox.Show(
                   "Log In Successfully Completed.\n\n Continue To Home Page.",
                   "Log In Successful",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                    if (res == DialogResult.OK)
                    {
                        Main_SignedIn Main_SignedIn = new Main_SignedIn();
                        Main_SignedIn.Show();

                        this.Close();
                        break;
                    }
                }
            }

        }

        private void Link_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm Signupform = new SignupForm();
            Signupform.Show();
            this.Hide();
        }
    }
}
