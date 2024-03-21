using Microsoft.EntityFrameworkCore;
using WinAppTracNghiem.Models;

namespace WinAppTracNghiem
{
    public partial class frmUpdateQuestion : Form
    {
        private readonly WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public bool InsertOrUpdate { get; set; }
        public int QuestionId { get; set; }
        public frmUpdateQuestion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void frmUpdateQuestion_Load(object sender, EventArgs e)
        {
            LoadType();
            LoadCourse();
            if (InsertOrUpdate)
            {
                Question ques = context.Questions.Include(q => q.CourseNavigation).
                    Include(q => q.TypeNavigation).FirstOrDefault(q => q.Id == QuestionId);
                txtTitle.Text = ques.Title;
                cbType.Text = ques.TypeNavigation.Name;
                cbCourse.Text = ques.CourseNavigation.Title;
                txtNumberAns.Text = ques.NumberOfAnswers.ToString();
                List<AnswersOfQuestion> listAns = context.AnswersOfQuestions.Include(a => a.AnswerNavigation).Where(a => a.Question == QuestionId).ToList();
                count = listAns.Count;
                txtAns1.Text = listAns[0].AnswerNavigation.Content.ToString();
                cbAns1.Checked = (bool)listAns[0].IsTrue;
                txtAns2.Text = listAns[1].AnswerNavigation.Content.ToString();
                cbAns2.Checked = (bool)listAns[1].IsTrue;
                if (ques.NumberOfAnswers > 2)
                {

                    for (int i = 3; i <= ques.NumberOfAnswers; i++)
                    {
                        TextBox txt = new TextBox();
                        txt.Location = new Point(496, 347 + 50 * (i - 1));
                        txt.Name = "txtAns" + i;
                        txt.Size = new Size(536, 27);
                        this.Controls.Add(txt);
                        txt.Text = listAns[i - 1].AnswerNavigation.Content.ToString();

                        CheckBox cbcheck = new CheckBox();
                        cbcheck.Location = new Point(1063, 347 + (50 * (i-1)));
                        cbcheck.Name = "cbAns" + i;
                        cbcheck.Text = "IsTrue";
                        cbcheck.Size = new Size(69, 24);
                        cbcheck.UseVisualStyleBackColor = true;
                        this.Controls.Add(cbcheck);
                        cbcheck.Checked = (bool)listAns[i - 1].IsTrue;
                    }
                }

            }
        }
        public void LoadType()
        {
            List<TypeOfQuestion> typeList = context.TypeOfQuestions.ToList();
            cbType.DataSource = typeList;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.SelectedIndex = 0;
        }

        public void LoadCourse()
        {
            var courseList = context.Courses.ToList();
            cbCourse.DataSource = courseList;
            cbCourse.DisplayMember = "Title";
            cbCourse.ValueMember = "Code";
            cbCourse.SelectedIndex = 0;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        int count = 2;
        private void btnAddAnsw_Click(object sender, EventArgs e)
        {
            TypeOfQuestion type = cbType.SelectedItem as TypeOfQuestion;
            if (type.Name.Equals("True/False"))
            {
                if (count > 2)
                {
                    MessageBox.Show("The type of question is True/False. The answers must have 2 answer!");
                }
            }
            else
            {
                if (count <= 5)
                {
                    count += 1;
                    TextBox txt = new TextBox();
                    txt.Location = new Point(496, 347 + 50 * (count - 1));
                    txt.Name = "txtAns" + count;
                    txt.Size = new Size(536, 27);
                    this.Controls.Add(txt);

                    CheckBox cbcheck = new CheckBox();
                    cbcheck.Location = new Point(1063, 347 + (50 * (count - 1)));
                    cbcheck.Name = "cbAns" + count;
                    cbcheck.Text = "IsTrue";
                    cbcheck.Size = new Size(69, 24);
                    cbcheck.UseVisualStyleBackColor = true;
                    this.Controls.Add(cbcheck);

                }
                else
                {
                    MessageBox.Show("You just can add 6 answer!");
                }
            }
        }

        private void btnDeleteAnsw_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete one answer at last?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (count > 2)
                {
                    string keyTxT = "txtAns" + count;
                    string keyCheckBox = "cbAns" + count;
                    Control[] controlsTXT = this.Controls.Find(keyTxT, true);
                    Control[] controlsCheckBox = this.Controls.Find(keyCheckBox, true);
                    if (controlsTXT.Length > 0 && controlsTXT[0] is TextBox
                        && controlsCheckBox.Length > 0 && controlsCheckBox[0] is CheckBox)
                    {
                        TextBox textBoxToDelete = (TextBox)controlsTXT[0];
                        this.Controls.Remove(textBoxToDelete);
                        CheckBox checkBoxDelete = (CheckBox)controlsCheckBox[0];
                        this.Controls.Remove(checkBoxDelete);
                        count -= 1;
                    }
                    else
                    {
                        MessageBox.Show("khong thay");
                    }
                }
                else
                {
                    MessageBox.Show("the answer must have at least 2 answer!");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";
            /*bool checkUpdate = false;*/
            TypeOfQuestion type = cbType.SelectedItem as TypeOfQuestion;
            if (type.Name.Equals("True/False"))
            {
                if (count > 2)
                {
                    MessageBox.Show("Type of question is True/False. Please just enter 2 answer!");
                }
                
            }else if (type.Name.Equals("One Answer"))
            {
                int countCheckBox = 0;
                for(int i=1; i <= count; i++)
                {
                    string keyCheckBox = "cbAns" + i;
                    Control[] controlsCheckBox = this.Controls.Find(keyCheckBox, true);
                    if (controlsCheckBox.Length > 0 && controlsCheckBox[0] is CheckBox)
                    {
                        CheckBox check = (CheckBox)controlsCheckBox[0];
                        if (check.Checked)
                        {
                            countCheckBox += 1;
                        }
                    }
                }
                if(countCheckBox > 1)
                {
                    MessageBox.Show("Type of question is one answer. Please choose 1 true answer!");
                }
            }
        }
    }
}
