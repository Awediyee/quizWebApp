using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace quizSystem
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public int TotalQuestions { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } // Navigation property
        public string Description { get; set; }
        public int TimeLimit { get; set; } // In minutes
        public int CreatedBy { get; set; }
        public User CreatedByUser { get; set; } // Navigation property
        public int? ApprovedBy { get; set; } // Nullable
        public User ApprovedByUser { get; set; } // Navigation property
        public string Status { get; set; } // pending, approved, rejected, in_review
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}