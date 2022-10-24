using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanishQuiz__coursework__Manus
{
    public partial class LeaderboardScreen : Form
    {
        User thisUser;
        User[] users;
        string previousForm;
        string selectedDifficulty;
        string selectedTopic;
        bool leaderboardLast;

        public LeaderboardScreen(User ThisUser, User[] Users, string PreviousForm, string SelectedDifficulty, string SelectedTopic)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            previousForm = PreviousForm;
            selectedDifficulty = SelectedDifficulty;
            selectedTopic = SelectedTopic;
            picAvatar.BackgroundImage = thisUser.Avatar;
            lblUsername.Text = thisUser.Username;
            lblLevel.Text = Convert.ToString(thisUser.Level);

            PopulatingLeaderBoard();
        }

        public LeaderboardScreen(User ThisUser, User[] Users, string PreviousForm)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            previousForm = PreviousForm;
            picAvatar.BackgroundImage = thisUser.Avatar;
            lblUsername.Text = thisUser.Username;
            lblLevel.Text = Convert.ToString(thisUser.Level);

            PopulatingLeaderBoard();
        }

        private void PopulatingLeaderBoard()
        {
            List<User> userStorer = new List<User>();
            List<User> highscoreSorter = new List<User>();
            User highestScore;
            int y = 0;
            int userStorerCount;
            int j = 0;


            foreach(User user in users) 
            {
                /*I have set every element in userStorer to be equivalent to the corresponding value in users
                This allows me to add and remove elements without effecting the user class*/
                userStorer.Add(user);
            }

            highestScore = userStorer[0]; //The first element of userStorer is set as the highest score as a reference
            userStorerCount = userStorer.Count; //The initial length of userStorer needs to be saved because its length dynamically changes
            
            for(int x = 0; x < userStorerCount; x++)
            {
                for(int i = 0; i < userStorer.Count(); i++)
                {
                    if(userStorer[i].Highscore > highestScore.Highscore) //If the highscore is greater than the previous highest highscore
                    {
                        y = i;
                        highestScore = userStorer[i]; //The new highest highscore is stored in highestScore
                    }
                }
                highscoreSorter.Add(highestScore); //Adds the highest score/next highest score to the next index in the list
                userStorer.Remove(userStorer[y]); //Removes the current/next highest score from userStorer
                if(userStorer.Count() != 0) //If there are no users left
                {
                    highestScore = userStorer[0]; //The remaining index in userStorer is assigned to highestScore
                }
                y = 0;
            }
            
            foreach(User user in users) //Displays users and highscores
            {
                highscoreLeaderboard.Items.Add((j + 1).ToString() + ". " + highscoreSorter[j].Username + " - " + "Level " + highscoreSorter[j].Level + " - " + highscoreSorter[j].Highscore);
                j++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(previousForm == "menu") //If the last form that the user was on was the menu screen, the back button will take them back to the menu screen
            {
                this.Hide();
                Form Form1 = new MenuScreen(thisUser, users);
                Form1.Show();
            }
            else //If the last form that the user was on was the results screen, the back button will take them back to the results screen
            {
                leaderboardLast = true;
                this.Hide();
                Form Form1 = new ResultsScreen(thisUser, users, selectedDifficulty, selectedTopic, leaderboardLast);
                //leaderboardLast is passed so that the constructor that doesn't call IncrementXp() is used
                Form1.Show();
            }
        }

        private void loginScreenHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new LoginScreenHelp();
            Form1.Show();
        }

        private void menuScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new MenuScreenHelp();
            Form1.Show();
        }

        private void quizSelectScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new QuizSelectScreenHelp();
            Form1.Show();
        }

        private void quizTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new QuizHelpMenu();
            Form1.Show();
        }

        private void resultsScreenTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new ResultsScreenHelp();
            Form1.Show();
        }

        private void leaderboardScreenHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new LeaderboardScreenHelp();
            Form1.Show();
        }

        private void profileScreenHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new ProfileScreenHelp();
            Form1.Show();
        }

        private void areYouSureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitProgramConfirmation = MessageBox.Show("Are you sure you want to close the program?", "Exit program", MessageBoxButtons.YesNo);

            if (exitProgramConfirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}