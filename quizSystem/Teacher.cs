using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizSystem
{
    public class Teacher
    {
        public int UserId { get; set; }
        public User User { get; set; } // Navigation property

        public int DepartmentId { get; set; }
        public Department Department { get; set; } // Navigation property

        public int? AddedBy { get; set; } // Nullable
        public User AddedByUser { get; set; } // Navigation property
    }
}