using Microsoft.VisualBasic.Logging;
using System.Numerics;
using static System.Net.WebRequestMethods;

namespace C__Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkSignIn_Main_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm SignInForm = new SignInForm();
            SignInForm.Show();
            this.Hide();
        }

        private void linkSignUp_Main_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm SignupForm = new SignupForm();
            SignupForm.Show();
            this.Hide();
        }

        private void linkCart_Main_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "You Have To Sign In Before Viewing Cart.",
                "Cart Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void picProduct1_Main_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }
        private void picProduct2_Main_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void buttonProduct1_Main_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }
        private void buttonProduct2_Main_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }
    }
}
