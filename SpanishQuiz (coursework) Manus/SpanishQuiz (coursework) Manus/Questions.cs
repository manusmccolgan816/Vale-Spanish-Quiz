using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishQuiz__coursework__Manus
{
    class Questions
    {
        int questionNumber;
        string question;
        string answer1;
        string answer2;
        string answer3;
        string answer4;
        string answer5;
        string answer6;
        string correctAnswer;
        string correctAnswer2;

        //Dropdown
        public Questions(int questionNumber, string question, string answer1, string answer2, string answer3, string correctAnswer)
        {
            QuestionNumber = questionNumber;
            Question = question;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            CorrectAnswer = correctAnswer;
        }
        //TextBox
        public Questions(int questionNumber, string question, string correctAnswer, string correctAnswer2)
        {
            QuestionNumber = questionNumber;
            Question = question;
            CorrectAnswer = correctAnswer;
            CorrectAnswer2 = correctAnswer2;
        }
        //RadioButtons
        public Questions(int questionNumber, string question, string answer1, string answer2, string answer3, string answer4, string answer5, string answer6, string correctAnswer)
        {
            QuestionNumber = questionNumber;
            Question = question;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            Answer5 = answer5;
            Answer6 = answer6;
            CorrectAnswer = correctAnswer;
        }

        public int QuestionNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string Answer1
        {
            get { return answer1; }
            set { answer1 = value; }
        }

        public string Answer2
        {
            get { return answer2; }
            set { answer2 = value; }
        }

        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }

        public string Answer4
        {
            get { return answer4; }
            set { answer4 = value; }
        }
        public string Answer5
        {
            get { return answer5; }
            set { answer5 = value; }
        }
        public string Answer6
        {
            get { return answer6; }
            set { answer6 = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string CorrectAnswer2
        {
            get { return correctAnswer2; }
            set { correctAnswer2 = value; }
        }
    }
}
