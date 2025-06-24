using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace quizSystem.Models
{
    public class QuestionOption
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; } // Navigation property

        public char OptionKey { get; set; } // A, B, C, D
        public string OptionText { get; set; }
    }
}