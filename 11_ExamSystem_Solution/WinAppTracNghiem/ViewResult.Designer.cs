namespace WinAppTracNghiem
{
    partial class ViewResult
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
            cboCourses = new ComboBox();
            cboSemesters = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dgvResult = new DataGridView();
            btnDes = new Button();
            Code = new Label();
            txtCode = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            dgvDes = new DataGridView();
            btnBack = new Button();
            btnHome = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCourses);
            groupBox1.Controls.Add(cboSemesters);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 61);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(480, 223);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(113, 112);
            cboCourses.Margin = new Padding(3, 4, 3, 4);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(138, 28);
            cboCourses.TabIndex = 5;
            cboCourses.SelectedIndexChanged += cboCourses_SelectedIndexChanged;
            // 
            // cboSemesters
            // 
            cboSemesters.FormattingEnabled = true;
            cboSemesters.Location = new Point(113, 60);
            cboSemesters.Margin = new Padding(3, 4, 3, 4);
            cboSemesters.Name = "cboSemesters";
            cboSemesters.Size = new Size(138, 28);
            cboSemesters.TabIndex = 4;
            cboSemesters.SelectedIndexChanged += cboSemesters_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Courses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Semesters:";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(495, 73);
            dgvResult.Margin = new Padding(3, 4, 3, 4);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 25;
            dgvResult.Size = new Size(1062, 920);
            dgvResult.TabIndex = 13;
            dgvResult.CellClick += dgvResult_CellClick;
            // 
            // btnDes
            // 
            btnDes.Location = new Point(183, 390);
            btnDes.Margin = new Padding(3, 4, 3, 4);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(86, 31);
            btnDes.TabIndex = 22;
            btnDes.Text = "Description";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += btnDes_Click;
            // 
            // Code
            // 
            Code.AutoSize = true;
            Code.Location = new Point(36, 355);
            Code.Name = "Code";
            Code.Size = new Size(47, 20);
            Code.TabIndex = 19;
            Code.Text = "Code:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(111, 351);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(229, 27);
            txtCode.TabIndex = 20;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 313);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 17;
            label4.Text = "Name:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(111, 309);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(138, 27);
            txtUsername.TabIndex = 18;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // dgvDes
            // 
            dgvDes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDes.Location = new Point(8, 447);
            dgvDes.Margin = new Padding(3, 4, 3, 4);
            dgvDes.Name = "dgvDes";
            dgvDes.RowHeadersWidth = 51;
            dgvDes.RowTemplate.Height = 25;
            dgvDes.Size = new Size(480, 545);
            dgvDes.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1460, 22);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1354, 22);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 31);
            btnHome.TabIndex = 15;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // ViewResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 1019);
            Controls.Add(groupBox1);
            Controls.Add(dgvResult);
            Controls.Add(btnDes);
            Controls.Add(Code);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(dgvDes);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Name = "ViewResult";
            Text = "ViewResult";
            KeyDown += ViewResult_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboCourses;
        private ComboBox cboSemesters;
        private Label label3;
        private Label label2;
        private DataGridView dgvResult;
        private Button btnDes;
        private Label Code;
        private TextBox txtCode;
        private Label label4;
        private TextBox txtUsername;
        private DataGridView dgvDes;
        private Button btnBack;
        private Button btnHome;
    }
}