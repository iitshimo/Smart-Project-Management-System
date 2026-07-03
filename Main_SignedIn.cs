using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C__Project
{
    public partial class Main_SignedIn : Form
    {
        public Main_SignedIn()
        {
            InitializeComponent();
        }

        private void linkCart_Main_SignedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CartForm cartForm = new CartForm();
            cartForm.Show();
            this.Hide();
        }

        private void buttonProduct1_Main_SignedIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Product Successfully Added To Cart.",
            "Added To Cart",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }
        private void buttonProduct2_Main_SignedIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Product Successfully Added To Cart.",
            "Added To Cart",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }
        private void panel1_Paint(object sender, EventArgs e)
        {

        }
    }
}
