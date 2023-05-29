using QuizAnswers;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

List<Question> questions;
List<UserAnswer> userAnswers;
List<CorrectAnswer> correctAnswers;
//Declaring Questions
questions = new List<Question>()
{
    new Question(1, "Q 1 - Which of the following is correct about variable naming conventions in C#?", 10, new List<string>() { "A - A name must begin with a letter that could be followed by a sequence of letters, digits (0 - 9) or underscore.","B - The first character in an identifier cannot be a digit.", "C - Both of the above.", "D - None of the above."}),
    new Question(2, "Q 2 - Which of the following converts a type to a Boolean value, where possible in C#?", 20, new List<string>(){"A - ToBoolean","B - ToSingle","C - ToChar","D - ToDateTime" }),
    new Question(3, "Q 3 - Which of the following converts a type to an unsigned big type in C#?", 30, new List<string>() { "A - ToType", "B - ToUInt16", "C - ToUInt32", "D - ToUInt64"}),
    new Question(4, "Q 5 What is a correct syntax to output \"Hello World\" in C#?", 10, new List<string>() { "A - Console.WriteLine(\"Hello World\");", "B - printf(\"Hello World\");", }),
};
// Declaring Correct Answers
correctAnswers = new List<CorrectAnswer>()
{
    new CorrectAnswer(1, "C"),
    new CorrectAnswer(2, "A"),
    new CorrectAnswer(3, "D"),
    new CorrectAnswer(4, "A"),
};

// print questions and get UserAnswers from user
userAnswers = new List<UserAnswer>();
foreach (var question in questions)
{
    Console.WriteLine(question.QuestionDescription);
    foreach (var option in question.QuestionOptions)
    {
        Console.WriteLine(option);
    }
    Console.WriteLine("Enter your answer: (Marks:" + question.QuestionMarks + ")");
    var answer = Console.ReadLine().ToUpper();
    userAnswers.Add(new UserAnswer(question.QuestionNo, answer, 0));
}

// print user answer and correct answer and update current marks
foreach (var userAnswer in userAnswers)
{
    Console.WriteLine("Q " + userAnswer.QuestionNo + "\nYour answer: " + userAnswer.Answer);
    // NOTE: LINQ was unnecessary. I could have just used a foreach loop to iterate through the correctAnswers list.
    // LINQ Query Syntax to get correct answer
    var correctAnswer = (from answer in correctAnswers
                         where answer.QuestionNo == userAnswer.QuestionNo
                         select answer).FirstOrDefault();
    if (userAnswer.QuestionNo == correctAnswer.QuestionNo)
    {

    }
    Console.WriteLine("Correct answer: " + correctAnswer.Answer);
    if (userAnswer.Answer == correctAnswer.Answer)
    {
        // NOTE: Here , I could have just used the userAnswer.CurrentMarks property instead of creating a new variable.
        // add question marks with current marks
        userAnswer.CurrentMarks = (from question in questions
                                   where question.QuestionNo == userAnswer.QuestionNo
                                   select question.QuestionMarks).FirstOrDefault();
    }
}
// calculate total marks and total question marks with sum of current marks
// NOTE: I could have just used the userAnswer.CurrentMarks property instead of creating a new variable.
var totalMarks = (from userAnswer in userAnswers
                  select userAnswer.CurrentMarks).Sum();
// NOTE: I could have just used the userAnswer.CurrentMarks property instead of creating a new variable.
var totalQuestionMarks = (from question in questions
                          select question.QuestionMarks).Sum();
Console.WriteLine("Result: " + totalMarks + "/" + totalQuestionMarks);
