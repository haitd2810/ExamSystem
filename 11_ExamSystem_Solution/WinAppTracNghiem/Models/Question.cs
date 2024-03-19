using System;
using System.Collections.Generic;

namespace WinAppTracNghiem.Models
{
    public partial class Question
    {
        public Question()
        {
            AnswersOfQuestions = new HashSet<AnswersOfQuestion>();
            ExamCodes = new HashSet<ExamCode>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public int? NumberOfAnswers { get; set; }
        public int? Type { get; set; }
        public string? Course { get; set; }

        public virtual Course? CourseNavigation { get; set; }
        public virtual TypeOfQuestion? TypeNavigation { get; set; }
        public virtual ICollection<AnswersOfQuestion> AnswersOfQuestions { get; set; }

        public virtual ICollection<ExamCode> ExamCodes { get; set; }
        public virtual ICollection<QuestionOfCode> QuestionOfCodes { get; set; }
    }
}
