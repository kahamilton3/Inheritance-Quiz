using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inheritance_Quiz
{
    public class Checkbox : Question
    {
        public List<string> AnswerChoices { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public Checkbox(List<string> answerChoices, List<string> correctAnswers, string questionText) : base(questionText)
        {
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;
        }
        public override bool AskQuestion()
        {
            Console.WriteLine(QuestionNumber + ") " + QuestionText);
            foreach (string choice in AnswerChoices)
            {
                Console.WriteLine(choice);
            }
            List<string> FinalAnswers = new List<string>();
            string answer = "";
            Console.WriteLine("Enter a correct answer: ");
            answer = Console.ReadLine();
            while (answer.ToLower() != "done")
            {
                FinalAnswers.Add(answer.ToLower());
                Console.WriteLine("Enter another correct answer, or enter 'done'.");
                answer = Console.ReadLine();
            }
            CorrectAnswers = CorrectAnswers.ConvertAll(d => d.ToLower());
            return Enumerable.SequenceEqual(CorrectAnswers.OrderBy(d => d), FinalAnswers.OrderBy(d =>d));
        }
    }
}
