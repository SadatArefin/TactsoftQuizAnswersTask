# Task

There are some multiple choice questions which user needs to answer. At the end, both user answer and correct answer needs to be shown and result which is user marks out of question marks

# My Approach

I created 3 classes: [Question](./Question.cs), [CorrectAnswer](./CorrectAnswer.cs) and [UserAnswer](./UserAnswer.cs). QuestionNo property was common among them to use as LINQ query. If I did not want to use LINQ query, it would have been unnecessary.

In the main class, I created List of objects of the classes and I manually input Question and CorrectAnswer list.

Next up, I created the option to show the question with option and marks and take user input to store it in UserAnswer list I created before.

Then, I showed the UserAnswer and the corresponding CorrectAnswer. I made it unnecessarily complex as I wanted to use LINQ query since I just recently learnt it.

Finally I have taken the total marks of user and total marks of question, again unnecessarily with LINQ query just to practice and showed the result.
