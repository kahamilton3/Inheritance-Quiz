using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Quiz
{
    public class Quiz
    {
        public string QuizName { get; set; }
        public List<Question> QuizQuestions = new List<Question>();
        private static int CorrectAnswers = 0;
        public Quiz(string quizName)
        {
            QuizName = quizName;
        }
        public void AddQuestions(Question question)
        {
            QuizQuestions.Add(question);
        }
        public void RunQuiz()
        {
            foreach (Question question in QuizQuestions)
            {
                bool response = question.AskQuestion();
                if (response)
                {
                    CorrectAnswers += 1;
                }
            }
            int numberOfQuestions = QuizQuestions.Count;
            Console.WriteLine("\n" + CorrectAnswers + " out of " + QuizQuestions.Count + " correct.");
        }
    }
}
