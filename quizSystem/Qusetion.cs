using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizSystem.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } // Navigation property

        public string QuestionText { get; set; }
        public string QuestionType { get; set; } // TrueFalse, MultipleChoice
        public string CorrectAnswer { get; set; }

        public ICollection<QuestionOption> QuestionOptions { get; set; } // Navigation property for options
    }
}