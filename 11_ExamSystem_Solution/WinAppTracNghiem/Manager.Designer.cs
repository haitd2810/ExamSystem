namespace WinAppTracNghiem
{
    partial class Manager
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
            btnManageExam = new Button();
            btnManage = new Button();
            btnViewResult = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnManageExam
            // 
            btnManageExam.Location = new Point(199, 74);
            btnManageExam.Name = "btnManageExam";
            btnManageExam.Size = new Size(240, 65);
            btnManageExam.TabIndex = 0;
            btnManageExam.Text = "Manage Exam";
            btnManageExam.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            btnManage.Location = new Point(199, 160);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(240, 65);
            btnManage.TabIndex = 0;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            // 
            // btnViewResult
            // 
            btnViewResult.Location = new Point(199, 249);
            btnViewResult.Name = "btnViewResult";
            btnViewResult.Size = new Size(240, 65);
            btnViewResult.TabIndex = 0;
            btnViewResult.Text = "View Result";
            btnViewResult.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(199, 343);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 65);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 501);
            Controls.Add(btnLogout);
            Controls.Add(btnViewResult);
            Controls.Add(btnManage);
            Controls.Add(btnManageExam);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageExam;
        private Button btnManage;
        private Button btnViewResult;
        private Button btnLogout;
    }
}