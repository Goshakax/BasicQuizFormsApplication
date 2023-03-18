using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_9v_6
{
    public class Question
    {
		private string questionText;
		private string rightAnswer;
        private List<string> allAnswers;
        private int number;
        private string givenAnswer;


        public Question(string questionText, string answer, List<string> allAnswers, int number)
		{
            QuestionText = questionText;
            RightAnswer = answer;
            AllAnswers = allAnswers;
            Number = number;
		}

        public string QuestionText { get { return questionText; } set { questionText = value; } }
        public string RightAnswer { get { return rightAnswer; } set { rightAnswer = value; } }
        public List<string> AllAnswers { get { return allAnswers; } set { allAnswers = value; } }
        public int Number { get { return number; } set { number = value; }}
        public string GivenAnswer { get { return givenAnswer; } set { givenAnswer = value; } }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Въпрос {Number}");
            sb.AppendLine($"  Подаден отговор: {GivenAnswer})");
            sb.AppendLine($"  Верен отговор: {RightAnswer})");

            if (RightAnswer  == GivenAnswer)
            {
                sb.AppendLine("Правилно!");
            }
            else
            {
                sb.AppendLine("Грешно!");
            }
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
