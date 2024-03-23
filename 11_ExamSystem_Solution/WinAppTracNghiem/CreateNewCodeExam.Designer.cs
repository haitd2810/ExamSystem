namespace WinAppTracNghiem
{
    partial class CreateNewCodeExam
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
            groupBox1 = new GroupBox();
            numQuestions = new NumericUpDown();
            numLong = new NumericUpDown();
            dtpDate = new DateTimePicker();
            txtCode = new TextBox();
            cboTime = new ComboBox();
            cboSemesters = new ComboBox();
            cboCourses = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTitle = new TextBox();
            txtIDQuestion = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnCreate = new Button();
            btnRemove = new Button();
            lstQuestions = new ListBox();
            dgvListQuestions = new DataGridView();
            btnHome = new Button();
            btnBack = new Button();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestions).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numQuestions);
            groupBox1.Controls.Add(numLong);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(cboTime);
            groupBox1.Controls.Add(cboSemesters);
            groupBox1.Controls.Add(cboCourses);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 571);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Code";
            // 
            // numQuestions
            // 
            numQuestions.Location = new Point(112, 493);
            numQuestions.Name = "numQuestions";
            numQuestions.Size = new Size(196, 27);
            numQuestions.TabIndex = 13;
            numQuestions.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // numLong
            // 
            numLong.Location = new Point(112, 424);
            numLong.Name = "numLong";
            numLong.Size = new Size(196, 27);
            numLong.TabIndex = 12;
            numLong.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(112, 288);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(269, 27);
            dtpDate.TabIndex = 11;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(112, 224);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(269, 27);
            txtCode.TabIndex = 10;
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cboTime.Location = new Point(112, 355);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(196, 28);
            cboTime.TabIndex = 9;
            // 
            // cboSemesters
            // 
            cboSemesters.FormattingEnabled = true;
            cboSemesters.Location = new Point(112, 87);
            cboSemesters.Name = "cboSemesters";
            cboSemesters.Size = new Size(196, 28);
            cboSemesters.TabIndex = 8;
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(112, 154);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(196, 28);
            cboCourses.TabIndex = 7;
            cboCourses.SelectedIndexChanged += cboCourses_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 500);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 6;
            label7.Text = "Question:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 431);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 5;
            label6.Text = "Long:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 363);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "Slot:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 295);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 231);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 162);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Course:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 95);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Semester:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Controls.Add(txtIDQuestion);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(22, 664);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 303);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add new Question:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(141, 114);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(283, 127);
            txtTitle.TabIndex = 30;
            // 
            // txtIDQuestion
            // 
            txtIDQuestion.Location = new Point(141, 67);
            txtIDQuestion.Name = "txtIDQuestion";
            txtIDQuestion.ReadOnly = true;
            txtIDQuestion.Size = new Size(198, 27);
            txtIDQuestion.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 167);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 28;
            label9.Text = "Title:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 74);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 27;
            label8.Text = "QuestionID:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(184, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(206, 994);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 27;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(505, 994);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 28;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstQuestions
            // 
            lstQuestions.FormattingEnabled = true;
            lstQuestions.ItemHeight = 20;
            lstQuestions.Location = new Point(479, 83);
            lstQuestions.Margin = new Padding(3, 4, 3, 4);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(154, 884);
            lstQuestions.TabIndex = 29;
            // 
            // dgvListQuestions
            // 
            dgvListQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListQuestions.Location = new Point(651, 83);
            dgvListQuestions.Name = "dgvListQuestions";
            dgvListQuestions.RowHeadersWidth = 51;
            dgvListQuestions.RowTemplate.Height = 29;
            dgvListQuestions.Size = new Size(935, 884);
            dgvListQuestions.TabIndex = 30;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1364, 25);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 14;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1492, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(579, 9);
            label10.Name = "label10";
            label10.Size = new Size(332, 51);
            label10.TabIndex = 31;
            label10.Text = "New Exam Code";
            // 
            // CreateNewCodeExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 1055);
            Controls.Add(label10);
            Controls.Add(btnHome);
            Controls.Add(btnBack);
            Controls.Add(dgvListQuestions);
            Controls.Add(lstQuestions);
            Controls.Add(btnRemove);
            Controls.Add(btnCreate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CreateNewCodeExam";
            Text = "CreateNewCodeExam";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private NumericUpDown numQuestions;
        private NumericUpDown numLong;
        private DateTimePicker dtpDate;
        private TextBox txtCode;
        private ComboBox cboTime;
        private ComboBox cboSemesters;
        private ComboBox cboCourses;
        private Label label9;
        private Label label8;
        private Button btnAdd;
        private Button btnCreate;
        private Button btnRemove;
        private TextBox txtTitle;
        private TextBox txtIDQuestion;
        private ListBox lstQuestions;
        private DataGridView dgvListQuestions;
        private Button btnHome;
        private Button btnBack;
        private Label label10;
    }
}