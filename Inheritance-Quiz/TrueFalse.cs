using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Quiz
{
    public class TrueFalse : Question
    {
        public readonly List<string> AnswerChoices = new List<string> { "True", "False" };
        public string CorrectAnswer { get; set; }
        public TrueFalse(string correctAnswer, string questionText) : base(questionText)
        {
            CorrectAnswer = correctAnswer;
        }
        public override bool AskQuestion()
        {
            Console.WriteLine(QuestionNumber + ") " + QuestionText);
            foreach (string choice in AnswerChoices)
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine("Enter your answer: ");
            string answer = Console.ReadLine();
            return CorrectAnswer.ToLower() == answer.ToLower();
        }
    }
}
