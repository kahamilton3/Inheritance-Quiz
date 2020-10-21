using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Quiz
{
    public abstract class Question
    {
        public int QuestionNumber { get; }
        private static int nextNumber = 1;
        public string QuestionText { get; set; }
        public Question(string questionText)
        {
            QuestionNumber = nextNumber;
            nextNumber++;
            QuestionText = questionText;
        }
        public virtual bool AskQuestion()
        {
            Console.WriteLine(QuestionNumber + ") " + QuestionText);
            return true;
        }
    }
}
