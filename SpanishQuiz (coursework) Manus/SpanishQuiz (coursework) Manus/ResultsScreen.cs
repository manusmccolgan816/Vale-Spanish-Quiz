using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SpanishQuiz__coursework__Manus
{
    public partial class ResultsScreen : Form
    {
        User thisUser;
        User[] users;
        string selectedDifficulty;
        string selectedTopic;
        List<User> usersList = new List<User>();
        string previousForm = "results";

        public ResultsScreen(User ThisUser, User[] Users, string SelectedDifficulty, string SelectedTopic)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            selectedDifficulty = SelectedDifficulty;
            selectedTopic = SelectedTopic;

            picAvatar.BackgroundImage = thisUser.Avatar;
            lblUsername.Text = thisUser.Username;
            if (selectedDifficulty == "hard")
            {
                thisUser.Score += 200;
            }
            lblScore.Text = Convert.ToString(thisUser.Score);

            IncrementXp();
            DisplayXp();
            lblLevel.Text = Convert.ToString(thisUser.Level);

            if (thisUser.Score > thisUser.Highscore)
            {
                lblNewHighscore.Visible = true;
                thisUser.Highscore = thisUser.Score;
            }

            ReadFromFile();
            WriteToFile();
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
        }

        public ResultsScreen(User ThisUser, User[] Users, string SelectedDifficulty, string SelectedTopic, bool LeaderboardLast)
        {
            //In this constructor, the xp is not incremented, as it is only used if the previous form was the leaderboard screen
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            selectedDifficulty = SelectedDifficulty;
            selectedTopic = SelectedTopic;

            picAvatar.BackgroundImage = thisUser.Avatar;
            lblUsername.Text = thisUser.Username;
            lblScore.Text = Convert.ToString(thisUser.Score);

            DisplayXp();
            lblLevel.Text = Convert.ToString(thisUser.Level);

            if (thisUser.Score > thisUser.Highscore)
            {
                lblNewHighscore.Visible = true;
                thisUser.Highscore = thisUser.Score;
            }

            ReadFromFile();
            WriteToFile();
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
        }

        private void IncrementXp()
        {
            if(thisUser.Level != 50) //If the maximum level hasn't been reached
            {
                thisUser.Xp += thisUser.Score;

                while(thisUser.Xp >= thisUser.MaxXp) //If the user's xp surpasses or equals the amount required to 'level up'
                {
                    thisUser.Level++; //User 'levels up'
                    thisUser.Xp -= Convert.ToInt32(thisUser.MaxXp); //Instead of dismissing the user's left over xp after levelling up, the left over xp is set as their new xp
                    thisUser.MaxXp *= 1.5; //The number of experience points required to level up increases with each increasing level
                    Math.Round(thisUser.MaxXp); //Rounds the maximum xp required to level up to the nearest integer
                    lblLevelUp.Visible = true;
                }
            }
            else
            {
                lblMaxXp.Text = "";
                lblMaxLevelReached.Visible = true;
            }
        }

        private void DisplayXp()
        {
            lblMaxXp.Text = Convert.ToString(thisUser.MaxXp);
            lblXp.Text = Convert.ToString(thisUser.Xp);
            if(!lblMaxLevelReached.Visible) //If the user hasn't reached the maximum level
            {
                prgXp.Maximum = Convert.ToInt32(thisUser.MaxXp);
                prgXp.Value = thisUser.Xp;
            }
        }

        private void ReadFromFile()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sr = File.OpenRead("Users.bin");
                users = (User[])bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteToFile()
        {
            int counter = 0, indexForAccounts = 0; ;

            foreach (User user in users)
            {
                counter++;
                if (user.Username == thisUser.Username)
                {
                    indexForAccounts = counter;
                }
            }

            //The index for account is -1 due to arrays having base 0
            users[indexForAccounts - 1] = thisUser;

            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sw = File.OpenWrite("Users.bin"); //Using openwrite will append to the file rather than overwriting
                bf.Serialize(sw, users); //Changed users to usersList
                sw.Close();
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new LeaderboardScreen(thisUser, users, previousForm, selectedDifficulty, selectedTopic);
            Form1.Show();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            DialogResult replayQuizConfirmation = MessageBox.Show("Are you sure you want to replay the quiz on the same difficulty and topic?", "Replay quiz", MessageBoxButtons.YesNo);

            if (replayQuizConfirmation == DialogResult.Yes)
            {
                this.Hide();
                Form Form1 = new TextBoxFramework(thisUser, users, selectedDifficulty, selectedTopic);
                Form1.Show();
            }
        }

        private void loginScreenHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new LoginScreenHelp();
            Form1.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new MenuScreen(thisUser, users);
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

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goo.gl/forms/764EbBgms8yUP3Yq1");
        }
    }
}