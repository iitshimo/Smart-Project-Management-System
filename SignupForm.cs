using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C__Project
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username_SignUp = txtUsername.Text.Trim();
            string password_SignUp = txtPassword.Text.Trim();

            if (username_SignUp == "" || password_SignUp == "")
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

                if (parts.Length == 2 && parts[0] == username_SignUp)
                {
                    DialogResult res = MessageBox.Show(
                    "Username already exists. Would You Like To Continue To Login Screen?",
                    "Sign Up Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                    );
                    if (res == DialogResult.Yes)
                    {
                        SignInForm login = new SignInForm();
                        login.Show();

                        this.Close();
                        break;
                    }
                    else
                    {
                        Main main = new Main();
                        main.Show();

                        this.Close();
                        break;
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(username_SignUp + "," + password_SignUp);
                    }


                    DialogResult result = MessageBox.Show(
                        "Account created successfully!\n\nDo you want to go to the login screen?",
                        "Signup Complete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        SignInForm login = new SignInForm();
                        login.Show();

                        this.Hide();
                        break;
                    }
                    else
                    {
                        Main main = new Main();
                        main.Show();

                        this.Close();
                        break;
                    }
                }
            }
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_SignUp_Click(object sender, EventArgs e)
        {

        }

        private void label2_SignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
