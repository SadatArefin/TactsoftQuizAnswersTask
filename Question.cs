using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAnswers
{
    public class Question
    {
        public int QuestionNo { get; set; }
        public string QuestionDescription { get; set; }
        public int QuestionMarks { get; set; }
        public List<string> QuestionOptions { get; set; }
        public Question(int questionNo, string questionDescription, int questionMarks, List<string> options)
        {
            QuestionNo = questionNo;
            QuestionDescription = questionDescription;
            QuestionMarks = questionMarks;
            QuestionOptions = options;
        }
    }
}
