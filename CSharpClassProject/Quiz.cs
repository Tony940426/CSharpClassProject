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
        private int _score;


        public Quiz(Question[] questions)
        {
            this.questions = questions;
            _score = 0;
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
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResult();
        }

        private void DisplayResult()
        {
            Console.WriteLine($"\nQuiz Over! Your score: {_score}/{questions.Length}");

            double percentage = ((double)_score / questions.Length) * 100;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;    
                Console.WriteLine("Excellent work!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You did bad!");
            }
        }
        
        private void DisplayQuestion(Question question)
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
