namespace WinAppTracNghiem
{
    partial class frmUpdateQuestion
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
            lbTitle = new Label();
            lbNumberAns = new Label();
            lbType = new Label();
            lbCourse = new Label();
            lbAnswer = new Label();
            txtAns1 = new TextBox();
            cbAns1 = new CheckBox();
            txtAns2 = new TextBox();
            cbAns2 = new CheckBox();
            btnAddAnsw = new Button();
            cbCourse = new ComboBox();
            cbType = new ComboBox();
            txtNumberAns = new TextBox();
            txtTitle = new RichTextBox();
            btnSave = new Button();
            btnBack = new Button();
            btnDeleteAns = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(339, 57);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(38, 20);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // lbNumberAns
            // 
            lbNumberAns.AutoSize = true;
            lbNumberAns.Location = new Point(343, 204);
            lbNumberAns.Name = "lbNumberAns";
            lbNumberAns.Size = new Size(135, 20);
            lbNumberAns.TabIndex = 0;
            lbNumberAns.Text = "Number Of Answer";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(343, 252);
            lbType.Name = "lbType";
            lbType.Size = new Size(40, 20);
            lbType.TabIndex = 0;
            lbType.Text = "Type";
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(343, 306);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(54, 20);
            lbCourse.TabIndex = 0;
            lbCourse.Text = "Course";
            // 
            // lbAnswer
            // 
            lbAnswer.AutoSize = true;
            lbAnswer.Location = new Point(343, 350);
            lbAnswer.Name = "lbAnswer";
            lbAnswer.Size = new Size(57, 20);
            lbAnswer.TabIndex = 0;
            lbAnswer.Text = "Answer";
            // 
            // txtAns1
            // 
            txtAns1.Location = new Point(496, 347);
            txtAns1.Name = "txtAns1";
            txtAns1.Size = new Size(536, 27);
            txtAns1.TabIndex = 1;
            // 
            // cbAns1
            // 
            cbAns1.AutoSize = true;
            cbAns1.Location = new Point(1063, 346);
            cbAns1.Name = "cbAns1";
            cbAns1.Size = new Size(69, 24);
            cbAns1.TabIndex = 2;
            cbAns1.Text = "IsTrue";
            cbAns1.UseVisualStyleBackColor = true;
            // 
            // txtAns2
            // 
            txtAns2.Location = new Point(496, 391);
            txtAns2.Name = "txtAns2";
            txtAns2.Size = new Size(536, 27);
            txtAns2.TabIndex = 1;
            // 
            // cbAns2
            // 
            cbAns2.AutoSize = true;
            cbAns2.Location = new Point(1063, 391);
            cbAns2.Name = "cbAns2";
            cbAns2.Size = new Size(69, 24);
            cbAns2.TabIndex = 2;
            cbAns2.Text = "IsTrue";
            cbAns2.UseVisualStyleBackColor = true;
            // 
            // btnAddAnsw
            // 
            btnAddAnsw.Location = new Point(129, 347);
            btnAddAnsw.Name = "btnAddAnsw";
            btnAddAnsw.Size = new Size(172, 29);
            btnAddAnsw.TabIndex = 3;
            btnAddAnsw.Text = "+Add More Answer";
            btnAddAnsw.UseVisualStyleBackColor = true;
            btnAddAnsw.Click += btnAddAnsw_Click;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(496, 303);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(332, 28);
            cbCourse.TabIndex = 4;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(496, 249);
            cbType.Name = "cbType";
            cbType.Size = new Size(166, 28);
            cbType.TabIndex = 4;
            // 
            // txtNumberAns
            // 
            txtNumberAns.Location = new Point(496, 201);
            txtNumberAns.Name = "txtNumberAns";
            txtNumberAns.ReadOnly = true;
            txtNumberAns.Size = new Size(125, 27);
            txtNumberAns.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(496, 32);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(406, 120);
            txtTitle.TabIndex = 6;
            txtTitle.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(171, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(171, 439);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteAns
            // 
            btnDeleteAns.Location = new Point(129, 302);
            btnDeleteAns.Name = "btnDeleteAns";
            btnDeleteAns.Size = new Size(172, 29);
            btnDeleteAns.TabIndex = 3;
            btnDeleteAns.Text = "-Delete Answer";
            btnDeleteAns.UseVisualStyleBackColor = true;
            btnDeleteAns.Click += btnDeleteAnsw_Click;
            // 
            // frmUpdateQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 545);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtTitle);
            Controls.Add(txtNumberAns);
            Controls.Add(cbType);
            Controls.Add(cbCourse);
            Controls.Add(btnDeleteAns);
            Controls.Add(btnAddAnsw);
            Controls.Add(cbAns2);
            Controls.Add(cbAns1);
            Controls.Add(txtAns2);
            Controls.Add(txtAns1);
            Controls.Add(lbNumberAns);
            Controls.Add(lbAnswer);
            Controls.Add(lbCourse);
            Controls.Add(lbType);
            Controls.Add(lbTitle);
            Name = "frmUpdateQuestion";
            Text = "frmUpdateQuestion";
            Load += frmUpdateQuestion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbNumberAns;
        private Label lbType;
        private Label lbCourse;
        private Label lbAnswer;
        private TextBox txtAns1;
        private CheckBox cbAns1;
        private TextBox txtAns2;
        private CheckBox cbAns2;
        private Button btnAddAnsw;
        private ComboBox cbCourse;
        private ComboBox cbType;
        private TextBox txtNumberAns;
        private RichTextBox txtTitle;
        private Button btnSave;
        private Button btnBack;
        private Button btnDeleteAns;
    }
}