using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAnswers
{
    public class UserAnswer
    {
        public int QuestionNo { get; set; }
        public string Answer { get; set; }
        public int CurrentMarks { get; set; }
        public UserAnswer(int questionNo, string answer, int currentMarks)
        {
            QuestionNo = questionNo;
            Answer = answer;
            CurrentMarks = currentMarks;
        }
    }
}
