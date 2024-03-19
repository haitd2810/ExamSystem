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
            lbCode = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            txtCode = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(62, 102);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(119, 26);
            lbCode.TabIndex = 0;
            lbCode.Text = "Exam Code";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(62, 204);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(104, 26);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(62, 309);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(102, 26);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(189, 102);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(358, 34);
            txtCode.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(189, 201);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(189, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 34);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(99, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 48);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(342, 440);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 48);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 585);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtCode);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbCode);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCode;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtCode;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
    }
}