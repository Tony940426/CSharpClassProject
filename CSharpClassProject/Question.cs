using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassProject
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string questionText, string[] answers, int correctAnswerIndex) 
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
            public bool IsCorrecctAnswer(int index)
            {
                return CorrectAnswerIndex == index;
            }
        }
    }
