namespace WinAppTracNghiem
{
    partial class Submit
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
            lbTime = new Label();
            lbStatus = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.ForeColor = Color.Red;
            lbTime.Location = new Point(208, 183);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(164, 68);
            lbTime.TabIndex = 0;
            lbTime.Text = "00:00";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.ForeColor = Color.Red;
            lbStatus.Location = new Point(33, 423);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(83, 33);
            lbStatus.TabIndex = 1;
            lbStatus.Text = "label1";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(436, 423);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 42);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Submit
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 519);
            Controls.Add(btnExit);
            Controls.Add(lbStatus);
            Controls.Add(lbTime);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Submit";
            Text = "Submit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTime;
        private Label lbStatus;
        private Button btnExit;
    }
}