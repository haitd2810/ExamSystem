using System;
using System.Collections.Generic;

namespace WinAppTracNghiem.Models
{
    public partial class TypeOfQuestion
    {
        public TypeOfQuestion()
        {
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
