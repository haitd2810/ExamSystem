namespace WinAppTracNghiem
{
    partial class ManageExamCode
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
            txtStatusAssign = new TextBox();
            txtUsernameAssign = new TextBox();
            txtCodeAssign = new TextBox();
            btnReAssign = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dgvExamCode = new DataGridView();
            dgvListQuestion = new DataGridView();
            btnCreateExamCode = new Button();
            groupBox3 = new GroupBox();
            numQuestions = new NumericUpDown();
            numLong = new NumericUpDown();
            cboTime = new ComboBox();
            dtpDateBegin = new DateTimePicker();
            cboStatus = new ComboBox();
            txtCode = new TextBox();
            btnDescription = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label11 = new Label();
            btnBack = new Button();
            btnHome = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExamCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestion).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLong).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStatusAssign);
            groupBox1.Controls.Add(txtUsernameAssign);
            groupBox1.Controls.Add(txtCodeAssign);
            groupBox1.Controls.Add(btnReAssign);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(24, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 582);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ReAssign";
            // 
            // txtStatusAssign
            // 
            txtStatusAssign.Location = new Point(104, 198);
            txtStatusAssign.Name = "txtStatusAssign";
            txtStatusAssign.ReadOnly = true;
            txtStatusAssign.Size = new Size(143, 27);
            txtStatusAssign.TabIndex = 8;
            // 
            // txtUsernameAssign
            // 
            txtUsernameAssign.Location = new Point(104, 128);
            txtUsernameAssign.Name = "txtUsernameAssign";
            txtUsernameAssign.Size = new Size(296, 27);
            txtUsernameAssign.TabIndex = 7;
            txtUsernameAssign.TextChanged += txtUsernameAssign_TextChanged;
            // 
            // txtCodeAssign
            // 
            txtCodeAssign.Location = new Point(104, 58);
            txtCodeAssign.Name = "txtCodeAssign";
            txtCodeAssign.ReadOnly = true;
            txtCodeAssign.Size = new Size(296, 27);
            txtCodeAssign.TabIndex = 6;
            // 
            // btnReAssign
            // 
            btnReAssign.Location = new Point(175, 319);
            btnReAssign.Name = "btnReAssign";
            btnReAssign.Size = new Size(94, 29);
            btnReAssign.TabIndex = 5;
            btnReAssign.Text = "Reassign";
            btnReAssign.UseVisualStyleBackColor = true;
            btnReAssign.Click += btnReAssign_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 135);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 205);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 4;
            label4.Text = "Status:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvExamCode);
            groupBox2.Controls.Add(dgvListQuestion);
            groupBox2.Controls.Add(btnCreateExamCode);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(492, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1206, 969);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "ExamCode";
            // 
            // dgvExamCode
            // 
            dgvExamCode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamCode.Location = new Point(670, 58);
            dgvExamCode.Name = "dgvExamCode";
            dgvExamCode.RowHeadersWidth = 51;
            dgvExamCode.RowTemplate.Height = 29;
            dgvExamCode.Size = new Size(530, 886);
            dgvExamCode.TabIndex = 3;
            // 
            // dgvListQuestion
            // 
            dgvListQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListQuestion.Location = new Point(22, 548);
            dgvListQuestion.Name = "dgvListQuestion";
            dgvListQuestion.RowHeadersWidth = 51;
            dgvListQuestion.RowTemplate.Height = 29;
            dgvListQuestion.Size = new Size(642, 396);
            dgvListQuestion.TabIndex = 2;
            // 
            // btnCreateExamCode
            // 
            btnCreateExamCode.Location = new Point(681, 23);
            btnCreateExamCode.Name = "btnCreateExamCode";
            btnCreateExamCode.Size = new Size(161, 29);
            btnCreateExamCode.TabIndex = 1;
            btnCreateExamCode.Text = "Add New Exam Code";
            btnCreateExamCode.UseVisualStyleBackColor = true;
            btnCreateExamCode.Click += btnCreateExamCode_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numQuestions);
            groupBox3.Controls.Add(numLong);
            groupBox3.Controls.Add(cboTime);
            groupBox3.Controls.Add(dtpDateBegin);
            groupBox3.Controls.Add(cboStatus);
            groupBox3.Controls.Add(txtCode);
            groupBox3.Controls.Add(btnDescription);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(22, 42);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(642, 500);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Information";
            // 
            // numQuestions
            // 
            numQuestions.Location = new Point(160, 362);
            numQuestions.Name = "numQuestions";
            numQuestions.Size = new Size(186, 27);
            numQuestions.TabIndex = 14;
            numQuestions.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numLong
            // 
            numLong.Location = new Point(160, 301);
            numLong.Name = "numLong";
            numLong.Size = new Size(186, 27);
            numLong.TabIndex = 13;
            numLong.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cboTime.Location = new Point(160, 232);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(186, 28);
            cboTime.TabIndex = 12;
            // 
            // dtpDateBegin
            // 
            dtpDateBegin.Location = new Point(160, 168);
            dtpDateBegin.Name = "dtpDateBegin";
            dtpDateBegin.Size = new Size(250, 27);
            dtpDateBegin.TabIndex = 11;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(160, 105);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(186, 28);
            cboStatus.TabIndex = 10;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(160, 41);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(287, 27);
            txtCode.TabIndex = 9;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // btnDescription
            // 
            btnDescription.Location = new Point(454, 423);
            btnDescription.Name = "btnDescription";
            btnDescription.Size = new Size(94, 29);
            btnDescription.TabIndex = 8;
            btnDescription.Text = "Description";
            btnDescription.UseVisualStyleBackColor = true;
            btnDescription.Click += btnDescription_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(267, 423);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(80, 423);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 369);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 5;
            label10.Text = "Questions:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 308);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 4;
            label9.Text = "Long:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 240);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 3;
            label8.Text = "Slot:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 175);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 2;
            label7.Text = "DateBegin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 108);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 1;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 48);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(432, 9);
            label1.Name = "label1";
            label1.Size = new Size(401, 51);
            label1.TabIndex = 1;
            label1.Text = "Manage Exam Code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(25, 9);
            label11.Name = "label11";
            label11.Size = new Size(0, 19);
            label11.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1606, 29);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1501, 29);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 31);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // ManageExamCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1727, 1055);
            Controls.Add(btnBack);
            Controls.Add(label11);
            Controls.Add(btnHome);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManageExamCode";
            Text = "ManageExamCode";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExamCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListQuestion).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtStatusAssign;
        private TextBox txtUsernameAssign;
        private TextBox txtCodeAssign;
        private Button btnReAssign;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private NumericUpDown numQuestions;
        private NumericUpDown numLong;
        private ComboBox cboTime;
        private DateTimePicker dtpDateBegin;
        private ComboBox cboStatus;
        private TextBox txtCode;
        private Button btnDescription;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvExamCode;
        private DataGridView dgvListQuestion;
        private Button btnCreateExamCode;
        private Label label11;
        private Button btnBack;
        private Button btnHome;
    }
}