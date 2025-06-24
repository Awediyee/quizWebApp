using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizSystem
{
    public class Result
    {
        public int ResultId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // Navigation property

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } // Navigation property

        public int Score { get; set; }
        public int TotalQuestions { get; set; }
    }
}