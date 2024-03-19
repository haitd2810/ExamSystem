using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppTracNghiem.Models
{
    public partial class QuestionOfCode
    {
        public string ExamCode { get; set; } = null!;
        public int Question { get; set; }

        public virtual ExamCode ExamCodeNavigation { get; set; } = null!;
        public virtual Question QuestionNavigation { get; set; } = null!;
    }
}
