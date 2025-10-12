using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassProject
{
    internal class Quiz
    {
        private Question[] questions;


        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }  

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1; 
            foreach (Question question in questions)
            {
                Console.WriteLine($"\nQuestion {questionNumber++}:");
                DisplayQuestion(question);

                int userChoice = GetUserChoice();
                if (question.IsCorrecctAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
        }
        
        public void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }

            if(GetUserChoice() == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("incorrect!");
            }
        }
        
        private int GetUserChoice()
        {
            Console.Write("Enter the number of your answer: ");
            string input = Console.ReadLine();

            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            };

            return choice - 1;
        }
    }
}
