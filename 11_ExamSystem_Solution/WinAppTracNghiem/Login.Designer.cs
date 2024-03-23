namespace WinAppTracNghiem
{
    partial class Login
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
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtCode = new TextBox();
            lbPassword = new Label();
            lbUsername = new Label();
            lbCode = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(314, 259);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 48);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(71, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 48);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(165, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 27);
            txtUsername.TabIndex = 15;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(165, 59);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(358, 27);
            txtCode.TabIndex = 16;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(38, 175);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 11;
            lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(38, 115);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 12;
            lbUsername.Text = "Username";
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(38, 59);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(84, 20);
            lbCode.TabIndex = 13;
            lbCode.Text = "Exam Code";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 384);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtCode);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbCode);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtCode;
        private Label lbPassword;
        private Label lbUsername;
        private Label lbCode;
    }
}