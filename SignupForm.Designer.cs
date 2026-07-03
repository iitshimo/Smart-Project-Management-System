namespace C__Project
{
    partial class SignupForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnExit = new Button();
            btnRegister = new Button();
            label2_SignUp = new Label();
            Label1_SignUp = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(362, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 47);
            txtUsername.TabIndex = 11;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(362, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 47);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(424, 283);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(188, 58);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(189, 283);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(188, 58);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2_SignUp
            // 
            label2_SignUp.AutoSize = true;
            label2_SignUp.Location = new Point(189, 197);
            label2_SignUp.Name = "label2_SignUp";
            label2_SignUp.Size = new Size(158, 41);
            label2_SignUp.TabIndex = 7;
            label2_SignUp.Text = "Password: ";
            label2_SignUp.Click += label2_SignUp_Click;
            // 
            // Label1_SignUp
            // 
            Label1_SignUp.AutoSize = true;
            Label1_SignUp.Location = new Point(189, 116);
            Label1_SignUp.Name = "Label1_SignUp";
            Label1_SignUp.Size = new Size(167, 41);
            Label1_SignUp.TabIndex = 6;
            Label1_SignUp.Text = "Username: ";
            Label1_SignUp.Click += label1_SignUp_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 458);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(label2_SignUp);
            Controls.Add(Label1_SignUp);
            Name = "SignupForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnExit;
        private Button btnRegister;
        private Label label2_SignUp;
        private Label Label1_SignUp;
    }
}