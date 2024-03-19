using System;
using System.Collections.Generic;

namespace WinAppTracNghiem.Models
{
    public partial class Practice
    {
        public string Username { get; set; } = null!;
        public string ExamCode { get; set; } = null!;
        public DateTime? TimeBegin { get; set; }
        public int? Long { get; set; }
        public decimal? Mark { get; set; }
        public string? Status { get; set; }

        public virtual ExamCode ExamCodeNavigation { get; set; } = null!;
        public virtual Account UsernameNavigation { get; set; } = null!;
    }
}
