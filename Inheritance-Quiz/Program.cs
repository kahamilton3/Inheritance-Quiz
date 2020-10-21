using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Inheritance_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string MultipleChoiceQuestion = "What is my favorite color?";
            List<string> MultipleChoiceAnswerChoices = new List<string> { "Red", "Orange", "Yellow", "Green" };
            string CheckboxQuestion = "What are the names of my dogs?";
            List<string> CheckboxAnswerChoices = new List<string> { "Nala", "Bob", "Fido", "Tucker" };
            List<string> CheckboxCorrectAnswer = new List<string> { "Nala", "Tucker" };
            string TrueFalseQuestion = "I went to Copenhagen on my honeymoon.";
            MultipleChoice testQuestion1 = new MultipleChoice(MultipleChoiceAnswerChoices, "Green", MultipleChoiceQuestion);
            Checkbox testQuestion2 = new Checkbox(CheckboxAnswerChoices, CheckboxCorrectAnswer, CheckboxQuestion);
            TrueFalse testQuestion3 = new TrueFalse("False", TrueFalseQuestion);
            Quiz testQuiz = new Quiz("About Me Quiz");
            testQuiz.AddQuestions(testQuestion1);
            testQuiz.AddQuestions(testQuestion2);
            testQuiz.AddQuestions(testQuestion3);
            testQuiz.RunQuiz();
        }
    }
}
