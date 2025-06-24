using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizSystem.Models
{
    public class Petition
    {
        public int PetitionId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // Navigation property

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } // Navigation property

        public string Msg { get; set; }
        public string Status { get; set; } // open, resolved

        public int? ResolvedBy { get; set; } // Nullable
        public User ResolvedByUser { get; set; } // Navigation property
    }
}