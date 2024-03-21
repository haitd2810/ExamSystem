namespace WinAppTracNghiem
{
    partial class frmQuestionManage
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
            gbFilter = new GroupBox();
            cbCourse = new ComboBox();
            cbType = new ComboBox();
            lbCourse = new Label();
            lbType = new Label();
            btnFilter = new Button();
            txtTitle = new TextBox();
            lbName = new Label();
            dgvDataQues = new DataGridView();
            btnCancel = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataQues).BeginInit();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(cbCourse);
            gbFilter.Controls.Add(cbType);
            gbFilter.Controls.Add(lbCourse);
            gbFilter.Controls.Add(lbType);
            gbFilter.Controls.Add(btnFilter);
            gbFilter.Controls.Add(txtTitle);
            gbFilter.Controls.Add(lbName);
            gbFilter.Location = new Point(58, 52);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(440, 494);
            gbFilter.TabIndex = 0;
            gbFilter.TabStop = false;
            gbFilter.Text = "Question";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Items.AddRange(new object[] { "All" });
            cbCourse.Location = new Point(69, 184);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(303, 28);
            cbCourse.TabIndex = 3;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "All" });
            cbType.Location = new Point(69, 116);
            cbType.Name = "cbType";
            cbType.Size = new Size(171, 28);
            cbType.TabIndex = 3;
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(6, 187);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(57, 20);
            lbCourse.TabIndex = 2;
            lbCourse.Text = "Course:";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(6, 119);
            lbType.Name = "lbType";
            lbType.Size = new Size(43, 20);
            lbType.TabIndex = 2;
            lbType.Text = "Type:";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(165, 252);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(69, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(171, 27);
            txtTitle.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(6, 63);
            lbName.Name = "lbName";
            lbName.Size = new Size(41, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Title:";
            // 
            // dgvDataQues
            // 
            dgvDataQues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataQues.Location = new Point(569, 52);
            dgvDataQues.Name = "dgvDataQues";
            dgvDataQues.RowHeadersWidth = 51;
            dgvDataQues.RowTemplate.Height = 29;
            dgvDataQues.Size = new Size(1330, 494);
            dgvDataQues.TabIndex = 1;
            dgvDataQues.CellClick += dgvQuesData_CellClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(127, 560);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Back";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(635, 560);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Create Question";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(987, 560);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Question";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1348, 560);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Question";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(313, 560);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmQuestionManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 601);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(btnCancel);
            Controls.Add(dgvDataQues);
            Controls.Add(gbFilter);
            Name = "frmQuestionManage";
            Text = "frmQuestionManage";
            Load += frmQuestionManage_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataQues).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilter;
        private ComboBox cbCourse;
        private ComboBox cbType;
        private Label lbCourse;
        private Label lbType;
        private TextBox txtTitle;
        private Label lbName;
        private DataGridView dgvDataQues;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnFilter;
    }
}