namespace C__Project
{
    partial class SignInForm
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
            Label_UserName_SignIn = new Label();
            Label_Password_SignIn = new Label();
            txtUserName_SignIn = new TextBox();
            txtPassword_SignIn = new TextBox();
            btnSignIn = new Button();
            btnExit_SignIn = new Button();
            Link_SignIn = new LinkLabel();
            Label_SignUp = new Label();
            SuspendLayout();
            // 
            // Label_UserName_SignIn
            // 
            Label_UserName_SignIn.AutoSize = true;
            Label_UserName_SignIn.Location = new Point(147, 119);
            Label_UserName_SignIn.Name = "Label_UserName_SignIn";
            Label_UserName_SignIn.Size = new Size(167, 41);
            Label_UserName_SignIn.TabIndex = 0;
            Label_UserName_SignIn.Text = "Username: ";
            // 
            // Label_Password_SignIn
            // 
            Label_Password_SignIn.AutoSize = true;
            Label_Password_SignIn.Location = new Point(147, 192);
            Label_Password_SignIn.Name = "Label_Password_SignIn";
            Label_Password_SignIn.Size = new Size(158, 41);
            Label_Password_SignIn.TabIndex = 1;
            Label_Password_SignIn.Text = "Password: ";
            // 
            // txtUserName_SignIn
            // 
            txtUserName_SignIn.Location = new Point(320, 113);
            txtUserName_SignIn.Name = "txtUserName_SignIn";
            txtUserName_SignIn.Size = new Size(250, 47);
            txtUserName_SignIn.TabIndex = 2;
            // 
            // txtPassword_SignIn
            // 
            txtPassword_SignIn.Location = new Point(320, 186);
            txtPassword_SignIn.Name = "txtPassword_SignIn";
            txtPassword_SignIn.Size = new Size(250, 47);
            txtPassword_SignIn.TabIndex = 3;
            txtPassword_SignIn.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(147, 256);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(188, 58);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnExit_SignIn
            // 
            btnExit_SignIn.Location = new Point(382, 256);
            btnExit_SignIn.Name = "btnExit_SignIn";
            btnExit_SignIn.Size = new Size(188, 58);
            btnExit_SignIn.TabIndex = 5;
            btnExit_SignIn.Text = "Exit";
            btnExit_SignIn.UseVisualStyleBackColor = true;
            // 
            // Link_SignIn
            // 
            Link_SignIn.AutoSize = true;
            Link_SignIn.Location = new Point(468, 330);
            Link_SignIn.Name = "Link_SignIn";
            Link_SignIn.Size = new Size(132, 41);
            Link_SignIn.TabIndex = 6;
            Link_SignIn.TabStop = true;
            Link_SignIn.Text = "Sign Up!";
            Link_SignIn.LinkClicked += Link_SignUp_LinkClicked;
            // 
            // Label_SignUp
            // 
            Label_SignUp.AutoSize = true;
            Label_SignUp.Location = new Point(123, 330);
            Label_SignUp.Name = "Label_SignUp";
            Label_SignUp.Size = new Size(339, 41);
            Label_SignUp.TabIndex = 7;
            Label_SignUp.Text = "Don't Have An Account?";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_SignUp);
            Controls.Add(Link_SignIn);
            Controls.Add(btnExit_SignIn);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword_SignIn);
            Controls.Add(txtUserName_SignIn);
            Controls.Add(Label_Password_SignIn);
            Controls.Add(Label_UserName_SignIn);
            Name = "SignInForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label Label_UserName_SignIn;
        private Label Label_Password_SignIn;
        private TextBox txtUserName_SignIn;
        private TextBox txtPassword_SignIn;
        private Button btnSignIn;
        private Button btnExit_SignIn;
        private LinkLabel Link_SignIn;
        private Label Label_SignUp;
    }
}