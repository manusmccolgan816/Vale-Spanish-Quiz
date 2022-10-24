using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpanishQuiz__coursework__Manus
{
    [Serializable] //Class must be marked as serializable for an object to be serialized
    public class User
    {
        string username;
        string password;
        Image avatar;
        int score;
        int highscore;
        int xp; //Stands for experience points
        int level;
        double maxXp;
        int[,] questionsAsked;

        public User()
        {
            username = String.Empty;
            password = String.Empty;
            avatar = null;
            highscore = 0;
            xp = 0;
            level = 1;
            maxXp = 2000;
            questionsAsked = new int[3, 50];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    questionsAsked[i, j] = -1;
                }
            }
        }

        public User(string username, string password, Image avatar, int score, int highscore, int xp, int level, double maxXp, int[,] questionsAsked)
        {
            Username = username;
            Password = password;
            Avatar = avatar;
            Score = score;
            Highscore = highscore;
            Xp = xp;
            Level = level;
            MaxXp = maxXp;
            QuestionsAsked = questionsAsked;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Highscore
        {
            get { return highscore; }
            set { highscore = value; }
        }
        
        public int Xp
        {
            get { return xp; }
            set { xp = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public double MaxXp
        {
            get { return maxXp; }
            set { maxXp = value; }
        }

        public int[,] QuestionsAsked
        {
            get { return questionsAsked; }
            set { questionsAsked = value; }
        }
    }
}