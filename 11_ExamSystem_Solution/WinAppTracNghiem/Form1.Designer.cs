namespace WinAppTracNghiem
{
    partial class Form1
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
            btnExit.Location = new Point(324, 269);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 48);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(81, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 48);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(175, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(175, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(175, 69);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(358, 27);
            txtCode.TabIndex = 8;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(48, 185);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(48, 125);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "Username";
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(48, 69);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(84, 20);
            lbCode.TabIndex = 5;
            lbCode.Text = "Exam Code";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 368);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtCode);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbCode);
            Name = "Form1";
            Text = "Form1";
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
