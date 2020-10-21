using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance_Quiz
{
    public class MultipleChoice : Question
    {
        public List<string> AnswerChoices { get; set; }
        public string CorrectAnswer { get; set; }
        public MultipleChoice(List<string> answerChoices, string correctAnswer, string questionText) : base(questionText)
        {
            AnswerChoices = answerChoices;
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
