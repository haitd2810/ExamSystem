namespace WinAppTracNghiem
{
    partial class Exam
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
            lbNumber = new Label();
            txtCode = new TextBox();
            txtNumber = new TextBox();
            lbtime = new Label();
            cbSubmit = new CheckBox();
            btnSubmit = new Button();
            gbInfo = new GroupBox();
            gbQuestion = new GroupBox();
            lbChoose = new Label();
            lbQuestion = new Label();
            textBox1 = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            txtTitle = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            gbInfo.SuspendLayout();
            gbQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(36, 35);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(61, 26);
            lbCode.TabIndex = 0;
            lbCode.Text = "Code";
            lbCode.Click += lbCode_Click;
            // 
            // lbNumber
            // 
            lbNumber.AutoSize = true;
            lbNumber.Location = new Point(36, 113);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(199, 26);
            lbNumber.TabIndex = 0;
            lbNumber.Text = "Number of question";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(239, 32);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(257, 34);
            txtCode.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(239, 110);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(257, 34);
            txtNumber.TabIndex = 1;
            // 
            // lbtime
            // 
            lbtime.AutoSize = true;
            lbtime.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbtime.ForeColor = Color.Red;
            lbtime.Location = new Point(608, 150);
            lbtime.Name = "lbtime";
            lbtime.Size = new Size(164, 68);
            lbtime.TabIndex = 0;
            lbtime.Text = "00:00";
            // 
            // cbSubmit
            // 
            cbSubmit.AutoSize = true;
            cbSubmit.Location = new Point(555, 31);
            cbSubmit.Name = "cbSubmit";
            cbSubmit.Size = new Size(186, 30);
            cbSubmit.TabIndex = 2;
            cbSubmit.Text = "I want to submit";
            cbSubmit.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(747, 26);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 35);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lbChoose);
            gbInfo.Controls.Add(lbQuestion);
            gbInfo.Controls.Add(btnNext);
            gbInfo.Controls.Add(btnBack);
            gbInfo.Controls.Add(textBox1);
            gbInfo.Location = new Point(12, 214);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(291, 431);
            gbInfo.TabIndex = 4;
            gbInfo.TabStop = false;
            gbInfo.Text = "Info";
            // 
            // gbQuestion
            // 
            gbQuestion.Controls.Add(txtTitle);
            gbQuestion.Location = new Point(320, 214);
            gbQuestion.Name = "gbQuestion";
            gbQuestion.Size = new Size(1030, 431);
            gbQuestion.TabIndex = 4;
            gbQuestion.TabStop = false;
            gbQuestion.Text = "Question";
            // 
            // lbChoose
            // 
            lbChoose.AutoSize = true;
            lbChoose.Location = new Point(24, 54);
            lbChoose.Name = "lbChoose";
            lbChoose.Size = new Size(194, 26);
            lbChoose.TabIndex = 0;
            lbChoose.Text = "Choose one answer";
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Location = new Point(24, 126);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(96, 26);
            lbQuestion.TabIndex = 0;
            lbQuestion.Text = "Question";
            lbQuestion.Click += lbCode_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(66, 34);
            textBox1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(24, 193);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(153, 193);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(108, 35);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(15, 34);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.ScrollBars = ScrollBars.Vertical;
            txtTitle.Size = new Size(1009, 194);
            txtTitle.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 678);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 30);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "I want to submit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(208, 673);
            button1.Name = "button1";
            button1.Size = new Size(108, 35);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 729);
            Controls.Add(gbQuestion);
            Controls.Add(gbInfo);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(btnSubmit);
            Controls.Add(cbSubmit);
            Controls.Add(txtNumber);
            Controls.Add(txtCode);
            Controls.Add(lbtime);
            Controls.Add(lbNumber);
            Controls.Add(lbCode);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Exam";
            Text = "Exam";
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            gbQuestion.ResumeLayout(false);
            gbQuestion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCode;
        private Label lbNumber;
        private TextBox txtCode;
        private TextBox txtNumber;
        private Label lbtime;
        private CheckBox cbSubmit;
        private Button btnSubmit;
        private GroupBox gbInfo;
        private Label lbChoose;
        private GroupBox gbQuestion;
        private Label lbQuestion;
        private Button btnNext;
        private Button btnBack;
        private TextBox textBox1;
        private TextBox txtTitle;
        private CheckBox checkBox1;
        private Button button1;
    }
}