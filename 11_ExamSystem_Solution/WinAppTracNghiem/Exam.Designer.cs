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
            components = new System.ComponentModel.Container();
            btnBack = new Button();
            lbChoose = new Label();
            btnNext = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtQuestionNow = new TextBox();
            txtQuestionsDone = new TextBox();
            label5 = new Label();
            txtTitle = new TextBox();
            groupBox1 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbTime = new Label();
            txtUserName = new TextBox();
            lbUser = new Label();
            btnSubmit = new Button();
            cbSumbit = new CheckBox();
            txtNumberOfQuestions = new TextBox();
            txtCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 208);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbChoose
            // 
            lbChoose.AutoSize = true;
            lbChoose.Location = new Point(23, 52);
            lbChoose.Name = "lbChoose";
            lbChoose.Size = new Size(120, 20);
            lbChoose.TabIndex = 15;
            lbChoose.Text = "Choose 1 answer";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(121, 208);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 122);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 0;
            label6.Text = "Question";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(lbChoose);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(txtQuestionNow);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(19, 174);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(251, 808);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info";
            // 
            // txtQuestionNow
            // 
            txtQuestionNow.Location = new Point(93, 117);
            txtQuestionNow.Margin = new Padding(3, 4, 3, 4);
            txtQuestionNow.Name = "txtQuestionNow";
            txtQuestionNow.ReadOnly = true;
            txtQuestionNow.Size = new Size(98, 27);
            txtQuestionNow.TabIndex = 13;
            // 
            // txtQuestionsDone
            // 
            txtQuestionsDone.ForeColor = Color.Red;
            txtQuestionsDone.Location = new Point(539, 132);
            txtQuestionsDone.Margin = new Padding(3, 4, 3, 4);
            txtQuestionsDone.Name = "txtQuestionsDone";
            txtQuestionsDone.ReadOnly = true;
            txtQuestionsDone.Size = new Size(114, 27);
            txtQuestionsDone.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 135);
            label5.Name = "label5";
            label5.Size = new Size(252, 20);
            label5.TabIndex = 24;
            label5.Text = "Number of questions you have done:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(18, 29);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.ScrollBars = ScrollBars.Vertical;
            txtTitle.Size = new Size(922, 111);
            txtTitle.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Location = new Point(277, 174);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(947, 808);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.ForeColor = Color.FromArgb(0, 0, 192);
            lbTime.Location = new Point(670, 60);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(131, 60);
            lbTime.TabIndex = 22;
            lbTime.Text = "00:00";
            // 
            // txtUserName
            // 
            txtUserName.ForeColor = Color.Red;
            txtUserName.Location = new Point(1158, 18);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(290, 27);
            txtUserName.TabIndex = 21;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(1114, 23);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(41, 20);
            lbUser.TabIndex = 20;
            lbUser.Text = "User:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(623, 12);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cbSumbit
            // 
            cbSumbit.AutoSize = true;
            cbSumbit.Location = new Point(426, 18);
            cbSumbit.Margin = new Padding(3, 4, 3, 4);
            cbSumbit.Name = "cbSumbit";
            cbSumbit.Size = new Size(191, 24);
            cbSumbit.TabIndex = 18;
            cbSumbit.Text = "I want to sumbit the test";
            cbSumbit.UseVisualStyleBackColor = true;
            // 
            // txtNumberOfQuestions
            // 
            txtNumberOfQuestions.ForeColor = Color.Red;
            txtNumberOfQuestions.Location = new Point(172, 75);
            txtNumberOfQuestions.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfQuestions.Name = "txtNumberOfQuestions";
            txtNumberOfQuestions.ReadOnly = true;
            txtNumberOfQuestions.Size = new Size(114, 27);
            txtNumberOfQuestions.TabIndex = 17;
            // 
            // txtCode
            // 
            txtCode.ForeColor = Color.Red;
            txtCode.Location = new Point(172, 24);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(205, 27);
            txtCode.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 79);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 15;
            label2.Text = "Number of questions:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 14;
            label1.Text = "Code";
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 1015);
            Controls.Add(groupBox2);
            Controls.Add(txtQuestionsDone);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(lbTime);
            Controls.Add(txtUserName);
            Controls.Add(lbUser);
            Controls.Add(btnSubmit);
            Controls.Add(cbSumbit);
            Controls.Add(txtNumberOfQuestions);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Exam";
            Text = "Exam";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbChoose;
        private Button btnNext;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtQuestionNow;
        private TextBox txtQuestionsDone;
        private Label label5;
        private TextBox txtTitle;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lbTime;
        private TextBox txtUserName;
        private Label lbUser;
        private Button btnSubmit;
        private CheckBox cbSumbit;
        private TextBox txtNumberOfQuestions;
        private TextBox txtCode;
        private Label label2;
        private Label label1;
    }
}