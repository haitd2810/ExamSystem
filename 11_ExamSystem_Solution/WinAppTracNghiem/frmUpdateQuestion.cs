using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using WinAppTracNghiem.Models;

namespace WinAppTracNghiem
{
    public partial class frmUpdateQuestion : Form
    {
        public bool InsertOrUpdate { get; set; }
        public int QuestionId { get; set; }
        int count = 2;
        public frmUpdateQuestion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void frmUpdateQuestion_Load(object sender, EventArgs e)
        {
            using var context = new WinAppTracNghiemContext();
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
                if (listAns.Count == 1)
                {
                    txtAns1.Text = listAns[0].AnswerNavigation.Content.ToString();
                    cbAns1.Checked = (bool)listAns[0].IsTrue;
                    txtAns2.Text = listAns[0].AnswerNavigation.Content.ToString();
                    cbAns2.Checked = (bool)listAns[0].IsTrue;
                    count = listAns.Count + 1;
                }
                else {
                    txtAns1.Text = listAns[0].AnswerNavigation.Content.ToString();
                    cbAns1.Checked = (bool)listAns[0].IsTrue;
                    txtAns2.Text = listAns[1].AnswerNavigation.Content.ToString();
                    cbAns2.Checked = (bool)listAns[1].IsTrue;
                }
                
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
                        cbcheck.Location = new Point(1063, 347 + (50 * (i - 1)));
                        cbcheck.Name = "cbAns" + i;
                        cbcheck.Text = "IsTrue";
                        cbcheck.Size = new Size(69, 24);
                        cbcheck.UseVisualStyleBackColor = true;
                        this.Controls.Add(cbcheck);
                        cbcheck.Checked = (bool)listAns[i - 1].IsTrue;
                    }
                }

            }
            else
            {
                txtNumberAns.Text = "2";
            }
        }
        public void LoadType()
        {
            using var context = new WinAppTracNghiemContext();
            List<TypeOfQuestion> typeList = context.TypeOfQuestions.ToList();
            cbType.DataSource = typeList;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.SelectedIndex = 0;
        }

        public void LoadCourse()
        {
            using var context = new WinAppTracNghiemContext();
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
        
        private void btnAddAnsw_Click(object sender, EventArgs e)
        {
            using var context = new WinAppTracNghiemContext();
            TypeOfQuestion type = cbType.SelectedItem as TypeOfQuestion;
            if (type.Name.Equals("True/False"))
            {
                if (count >= 2)
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
                    int NumAns = int.Parse(txtNumberAns.Text) + 1;
                    txtNumberAns.Text = NumAns.ToString();

                }
                else
                {
                    MessageBox.Show("You just can add 6 answer!");
                }
            }
        }

        private void btnDeleteAnsw_Click(object sender, EventArgs e)
        {
            using var context = new WinAppTracNghiemContext();
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
                        int NumAns = int.Parse(txtNumberAns.Text) - 1;
                        txtNumberAns.Text = NumAns.ToString();
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
        public bool CheckHaveTrueAnswer()
        {
            using var context = new WinAppTracNghiemContext();
            int countTrueAns = 0;
            for (int i = 1; i <= count; i++)
            {
                string keyCheckBox = "cbAns" + i;
                Control[] controlsCheckBox = this.Controls.Find(keyCheckBox, true);
                if (controlsCheckBox.Length > 0 && controlsCheckBox[0] is CheckBox)
                {
                    CheckBox check = (CheckBox)controlsCheckBox[0];
                    if (check.Checked)
                    {
                        countTrueAns++;
                    }
                }
            }
            if (countTrueAns == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool CheckOneAnswer()
        {
            using var context = new WinAppTracNghiemContext();
            int countTrueAns = 0;
            for (int i = 1; i <= count; i++)
            {
                string keyCheckBox = "cbAns" + i;
                Control[] controlsCheckBox = this.Controls.Find(keyCheckBox, true);
                if (controlsCheckBox.Length > 0 && controlsCheckBox[0] is CheckBox)
                {
                    CheckBox check = (CheckBox)controlsCheckBox[0];
                    if (check.Checked)
                    {
                        countTrueAns++;
                    }
                }
            }
            if (countTrueAns > 1)
            {
                return true;
            }
            else { return false; }
        }
        public bool IsAnswerEmpty()
        {
            using var context = new WinAppTracNghiemContext();
            bool checkEmpty = false;
            for (int i = 1; i <= count; i++)
            {
                string keyTxT = "txtAns" + i;

                Control[] controlsTXT = this.Controls.Find(keyTxT, true);

                if (controlsTXT.Length > 0 && controlsTXT[0] is TextBox)
                {
                    TextBox txt = (TextBox)controlsTXT[0];
                    if (txt.Text.Trim().Length == 0)
                    {
                        checkEmpty = true;
                    }
                }
            }
            if (checkEmpty)
            {
                return true;
            }
            else { return false; }
        }

        public void UpdateQuestion()
        {
            using var context = new WinAppTracNghiemContext();
            string message = "";
            bool checkUpdate = false;
            TypeOfQuestion type = cbType.SelectedItem as TypeOfQuestion;
            if (type.Name.Equals("True/False"))
            {
                if (count > 2)
                {
                    message = "Type of question is True/False. Please just enter 2 answer!";
                    checkUpdate = false;
                }
                else
                {
                    if (CheckOneAnswer())
                    {
                        message = "Type of question is True/False. Please choose 1 true answer!";
                        checkUpdate = false;
                    }
                    else
                    {
                        if (CheckValidAnswer())
                        {
                            checkUpdate = true;
                        }
                        else
                        {
                            checkUpdate = false;
                        }
                    }
                }

            }
            else if (type.Name.Equals("One Answer"))
            {
                
                if (CheckOneAnswer())
                {
                    message = "Type of question is one answer. Please choose 1 true answer!";
                    checkUpdate = false;
                }
                else
                {
                    if (CheckValidAnswer())
                    {
                        checkUpdate = true;
                    }
                    else
                    {
                        checkUpdate = false;
                    }
                }
            }
            else
            {
                if (CheckValidAnswer())
                {
                    checkUpdate = true;
                }
                else
                {
                    checkUpdate = false;
                }
            }
            
            if (checkUpdate == true)
            {
                TypeOfQuestion typeUpdate = cbType.SelectedItem as TypeOfQuestion;
                Course courseUpdate = cbCourse.SelectedItem as Course;
                string Title = txtTitle.Text;
                int NumberAns = int.Parse(txtNumberAns.Text);
                Question ques = context.Questions.FirstOrDefault(q => q.Id == QuestionId);
                if (ques != null)
                {
                    //update question
                    ques.Course = courseUpdate.Code;
                    ques.Type = typeUpdate.Id;
                    ques.Title = Title;
                    ques.NumberOfAnswers = NumberAns;
                    context.Questions.Update(ques);
                    context.SaveChanges();
                    //get the new update question
                    List<bool> isTrue = new List<bool>();
                    List<String> content = new List<string>();
                    //save new answer to list
                    SaveNewAnswer(content, isTrue); 
                    //remove old answer
                    RemoveOldAns();
                    //change new answer by get new answer from list
                    AddNewAns(content, isTrue);
                    message = "Update Successfully!";
                }

            }
            if (message.Trim().Length > 0) { MessageBox.Show(message); }

        }

        public void SaveNewAnswer(List<string> content, List<bool> isTrue)
        {
            for (int i = 1; i <= count; i++)
            {
                string keyTxT = "txtAns" + i;
                string keyCheckBox = "cbAns" + i;
                Control[] controlsTXT = this.Controls.Find(keyTxT, true);
                Control[] controlsCheckBox = this.Controls.Find(keyCheckBox, true);
                if (controlsTXT.Length > 0 && controlsTXT[0] is TextBox
                && controlsCheckBox.Length > 0 && controlsCheckBox[0] is CheckBox)
                {
                    isTrue.Add(((CheckBox)controlsCheckBox[0]).Checked);
                    content.Add(((TextBox)controlsTXT[0]).Text.ToString());
                }
            }
        }

        public void AddNewAns(List<string> content, List<bool> isTrue)
        {
            using var context = new WinAppTracNghiemContext();
            //add new answer
            foreach (string a in content)
            {
                Answer answer = new Answer
                {
                    Content = a
                };
                context.Answers.Add(answer);
                context.SaveChanges();
            }
            for (int i = 0; i < isTrue.Count; i++)
            {

                Answer a = context.Answers.OrderBy(answ => answ.Id).LastOrDefault(a => a.Content.Equals(content[i]));
                AnswersOfQuestion ans = new AnswersOfQuestion
                {
                    Question = QuestionId,
                    Answer = a.Id,
                    IsTrue = isTrue[i]
                };
                context.AnswersOfQuestions.Add(ans);
                context.SaveChanges();
            }
        }

        public void RemoveOldAns()
        {
            using var context = new WinAppTracNghiemContext();
            List<AnswersOfQuestion> listAns = context.AnswersOfQuestions.Where(a => a.Question == QuestionId).ToList();
            List<int> answerID = new List<int>();
            foreach (AnswersOfQuestion a in listAns)
            {
                answerID.Add(a.Answer);
                context.AnswersOfQuestions.Remove(a);
                context.SaveChanges();
            }
            foreach (int id in answerID)
            {
                Answer ans = context.Answers.Where(a => a.Id == id).FirstOrDefault();
                if (ans != null)
                {
                    context.Answers.Remove(ans);
                    context.SaveChanges();
                }
            }
        }

        public bool CheckValidAnswer()
        {
            string mess = "";
            bool check = false;
            if(txtTitle.Text.Length < 50)
            {
                mess = "please enter title with at least 50 characters";
                check = false;
            }
            else {
                if (IsAnswerEmpty())
                {
                    mess = "Please enter all textbox answer!";
                    check = false;
                }
                else
                {
                    if (CheckHaveTrueAnswer())
                    {
                        mess = "Please choose at 1 answer is true!";
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            
            if(mess.Trim().Length > 0) { MessageBox.Show(mess); }
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddNewQuestion()
        {
            using var context = new WinAppTracNghiemContext();
            string message = "";
            bool checkAdd = false;
            TypeOfQuestion type = cbType.SelectedItem as TypeOfQuestion;
            if (type.Name.Equals("True/False"))
            {
                if (count > 2)
                {
                    message = "Type of question is True/False. Please just enter 2 answer!";
                    checkAdd = false;
                }
                else
                {
                    if (CheckOneAnswer())
                    {
                        message = "Type of question is True/False. Please choose 1 true answer!";
                        checkAdd = false;
                    }
                    else
                    {
                        if (CheckValidAnswer())
                        {
                            checkAdd = true;
                        }
                        else
                        {
                            checkAdd = false;
                        }
                    }
                }

            }
            else if (type.Name.Equals("One Answer"))
            {

                if (CheckOneAnswer())
                {
                    message = "Type of question is one answer. Please choose 1 true answer!";
                    checkAdd = false;
                }
                else
                {
                    if (CheckValidAnswer())
                    {
                        checkAdd = true;
                    }
                    else
                    {
                        checkAdd = false;
                    }
                }
            }
            else
            {
                if (CheckValidAnswer())
                {
                    checkAdd = true;
                }
                else
                {
                    checkAdd = false;
                }
            }
            if (checkAdd == true)
            {
                Question ques = context.Questions.FirstOrDefault(q => q.Id == QuestionId);
                if (ques != null)
                {
                    message = "The Question is exist on system!";
                }
                else
                {
                    TypeOfQuestion typeAdd = cbType.SelectedItem as TypeOfQuestion;
                    Course courseAdd = cbCourse.SelectedItem as Course;
                    string Title = txtTitle.Text;
                    int NumberAns = int.Parse(txtNumberAns.Text);
                    Question question = new Question
                    {
                        Title = Title,
                        NumberOfAnswers = NumberAns,
                        Type = typeAdd.Id,
                        Course = courseAdd.Code
                    };
                    context.Questions.Add(question);
                    context.SaveChanges();
                    Question FindQues = context.Questions.FirstOrDefault(q => q.Title.Equals(question.Title) && q.NumberOfAnswers == question.NumberOfAnswers
                    && q.Type == question.Type && q.Course.Equals(question.Course));
                    QuestionId = FindQues.Id;
                    //get the new update question
                    List<bool> isTrue = new List<bool>();
                    List<String> content = new List<string>();
                    //save new answer to list
                    SaveNewAnswer(content, isTrue);
                    //change new answer by get new answer from list
                    AddNewAns(content, isTrue);
                    message = "Add Successfully!";

                }
            }
            if (message.Trim().Length > 0) { MessageBox.Show(message); }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                UpdateQuestion();
            }
            else
            {
                AddNewQuestion();
            }
        }
    }
}
