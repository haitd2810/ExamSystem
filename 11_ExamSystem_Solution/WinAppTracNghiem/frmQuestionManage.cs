using Microsoft.EntityFrameworkCore;
using System.Data;
using WinAppTracNghiem.Models;

namespace WinAppTracNghiem
{
    public partial class frmQuestionManage : Form
    {
        public frmQuestionManage()
        {
            InitializeComponent();
        }
        private WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        BindingSource source;
        private void frmQuestionManage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            LoadQuestion();
            LoadCourse();
            LoadType();
        }
        public void LoadQuestion()
        {
            var question = context.Questions.Include(q => q.TypeNavigation).Include(q => q.CourseNavigation).ToList();
            var questionData = from q in question
                               select new
                               {
                                   q.Id,
                                   q.Title,
                                   NumberOfAnswers = q.NumberOfAnswers,
                                   QuestionType = q.TypeNavigation.Name,
                                   CourseCode = q.CourseNavigation.Code,
                                   CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                               };
            source = new BindingSource();
            source.DataSource = questionData;
            dgvDataQues.DataSource = null;
            dgvDataQues.DataSource = source;
        }

        public void LoadType()
        {
            var typeList = context.TypeOfQuestions.ToList();
            typeList.Add(new TypeOfQuestion
            {
                Id = 0,
                Name = "All"
            });
            cbType.DataSource = typeList;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.SelectedIndex = 0;
        }

        public void LoadCourse()
        {
            var courseList = context.Courses.ToList();
            courseList.Add(new Course
            {
                Code = "0",
                Title = "All"
            });
            cbCourse.DataSource = courseList;
            cbCourse.DisplayMember = "Title";
            cbCourse.ValueMember = "Code";
            cbCourse.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        int questionID = 0;
        private void dgvQuesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDataQues.Rows[e.RowIndex];
                questionID = int.Parse(selectedRow.Cells[0].Value.ToString());
            }
        }
        public void Filter()
        {
            var question = context.Questions.Include(q => q.TypeNavigation).Include(q => q.CourseNavigation).ToList();
            var questionData = from q in question
                               select new
                               {
                                   q.Id,
                                   q.Title,
                                   NumberOfAnswers = q.NumberOfAnswers,
                                   QuestionType = q.TypeNavigation.Name,
                                   CourseCode = q.CourseNavigation.Code,
                                   CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                               };
            TypeOfQuestion type = (TypeOfQuestion)cbType.SelectedItem;
            Course course = (Course)cbCourse.SelectedItem;
            if (type.Id != 0 && course.Code != "0")
            {
                if (txtTitle.Text.Length > 0)
                {
                    questionData = from q in question
                                   where q.Title.Contains(txtTitle.Text) && q.TypeNavigation.Id == type.Id && q.CourseNavigation.Code.Equals(course.Code)
                                   select new
                                   {
                                       q.Id,
                                       q.Title,
                                       NumberOfAnswers = q.NumberOfAnswers,
                                       QuestionType = q.TypeNavigation.Name,
                                       CourseCode = q.CourseNavigation.Code,
                                       CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                                   };
                }
                else
                {
                    questionData = from q in question
                                   where q.TypeNavigation.Id == type.Id && q.CourseNavigation.Code.Equals(course.Code)
                                   select new
                                   {
                                       q.Id,
                                       q.Title,
                                       NumberOfAnswers = q.NumberOfAnswers,
                                       QuestionType = q.TypeNavigation.Name,
                                       CourseCode = q.CourseNavigation.Code,
                                       CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                                   };
                }
            }
            else if (type.Id == 0 && course.Code != "0")
            {
                if (txtTitle.Text.Length > 0)
                {
                    questionData = from q in question
                                   where q.Title.Contains(txtTitle.Text) && q.CourseNavigation.Code.Equals(course.Code)
                                   select new
                                   {
                                       q.Id,
                                       q.Title,
                                       NumberOfAnswers = q.NumberOfAnswers,
                                       QuestionType = q.TypeNavigation.Name,
                                       CourseCode = q.CourseNavigation.Code,
                                       CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                                   };
                }
                else
                {
                    questionData = from q in question
                                   where q.CourseNavigation.Code.Equals(course.Code)
                                   select new
                                   {
                                       q.Id,
                                       q.Title,
                                       NumberOfAnswers = q.NumberOfAnswers,
                                       QuestionType = q.TypeNavigation.Name,
                                       CourseCode = q.CourseNavigation.Code,
                                       CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                                   };
                }
            }
            else if (type.Id != 0 && course.Code == "0")
            {
                if (txtTitle.Text.Length > 0)
                {
                    questionData = from q in question
                                   where q.Title.Contains(txtTitle.Text) && q.TypeNavigation.Id == type.Id
                                   select new
                                   {
                                       q.Id,
                                       q.Title,
                                       NumberOfAnswers = q.NumberOfAnswers,
                                       QuestionType = q.TypeNavigation.Name,
                                       CourseCode = q.CourseNavigation.Code,
                                       CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                                   };
                }
                else
                {
                    questionData = from q in question
                                   where q.TypeNavigation.Id == type.Id
                                   select new
                                   {
                                       q.Id,
                                       q.Title,
                                       NumberOfAnswers = q.NumberOfAnswers,
                                       QuestionType = q.TypeNavigation.Name,
                                       CourseCode = q.CourseNavigation.Code,
                                       CourseName = q.CourseNavigation.Title == null ? " " : q.CourseNavigation.Title,
                                   };
                }
            }
            source = new BindingSource();
            source.DataSource = questionData;
            dgvDataQues.DataSource = null;
            dgvDataQues.DataSource = source;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadQuestion();
            LoadType();
            LoadCourse();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QuestionOfCode qs = context.QuestionOfCodes.FirstOrDefault(q => q.Question == questionID);
            if(qs != null)
            {
                MessageBox.Show("This question is used in exam code, cannot delete!");
            }
            else {
            Question q = null;
            q = context.Questions.Where(q => q.Id == questionID).FirstOrDefault();
            List<AnswersOfQuestion> aq = context.AnswersOfQuestions.Where(a => a.Question == questionID).ToList();
                if (q == null || aq.Count() == 0)
                {
                    MessageBox.Show("The question is not exist!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to delete question?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            foreach (AnswersOfQuestion a in aq)
                            {
                                context.AnswersOfQuestions.Remove(a);
                            }
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ans");
                        }
                        try
                        {
                            context.Questions.Remove(q);
                            context.SaveChanges();
                            MessageBox.Show("Delete Success!");
                            LoadQuestion();
                            LoadCourse();
                            LoadType();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ques");
                        }
                    }
                }
            }
        }
    }
}
