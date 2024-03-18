namespace Esemka_Laundry
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoginTittle = new Label();
            lblLoginUsername = new Label();
            lblLoginPassword = new Label();
            tbLoginUsername = new TextBox();
            tbLoginPassword = new TextBox();
            btnLoginReset = new Button();
            btnLoginLogin = new Button();
            SuspendLayout();
            // 
            // lblLoginTittle
            // 
            lblLoginTittle.AutoSize = true;
            lblLoginTittle.Font = new Font("Segoe UI", 14F);
            lblLoginTittle.Location = new Point(137, 9);
            lblLoginTittle.Name = "lblLoginTittle";
            lblLoginTittle.Size = new Size(186, 32);
            lblLoginTittle.TabIndex = 0;
            lblLoginTittle.Text = "Esemka Laundry";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Location = new Point(34, 87);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(82, 20);
            lblLoginUsername.TabIndex = 1;
            lblLoginUsername.Text = "Username :";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(34, 132);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(77, 20);
            lblLoginPassword.TabIndex = 2;
            lblLoginPassword.Text = "Password :";
            // 
            // tbLoginUsername
            // 
            tbLoginUsername.Location = new Point(146, 84);
            tbLoginUsername.Name = "tbLoginUsername";
            tbLoginUsername.Size = new Size(269, 27);
            tbLoginUsername.TabIndex = 3;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(146, 125);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.PasswordChar = '*';
            tbLoginPassword.Size = new Size(269, 27);
            tbLoginPassword.TabIndex = 4;
            // 
            // btnLoginReset
            // 
            btnLoginReset.Location = new Point(146, 196);
            btnLoginReset.Name = "btnLoginReset";
            btnLoginReset.Size = new Size(94, 29);
            btnLoginReset.TabIndex = 5;
            btnLoginReset.Text = "Reset";
            btnLoginReset.UseVisualStyleBackColor = true;
            btnLoginReset.Click += btnLoginReset_Click;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.Location = new Point(255, 196);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(94, 29);
            btnLoginLogin.TabIndex = 6;
            btnLoginLogin.Text = "Login";
            btnLoginLogin.UseVisualStyleBackColor = true;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 285);
            Controls.Add(btnLoginLogin);
            Controls.Add(btnLoginReset);
            Controls.Add(tbLoginPassword);
            Controls.Add(tbLoginUsername);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(lblLoginTittle);
            Name = "LoginForm";
            Text = "Esemka Laundry - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginTittle;
        private Label lblLoginUsername;
        private Label lblLoginPassword;
        private TextBox tbLoginUsername;
        private TextBox tbLoginPassword;
        private Button btnLoginReset;
        private Button btnLoginLogin;
    }
}
