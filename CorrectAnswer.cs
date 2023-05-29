using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAnswers
{
    public class CorrectAnswer
    {
        public int QuestionNo { get; set; }
        public string Answer { get; set; }
        public CorrectAnswer(int questionNo, string answer)
        {
            QuestionNo = questionNo;
            Answer = answer;
        }
    }
}
