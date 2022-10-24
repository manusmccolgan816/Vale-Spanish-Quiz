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
    public partial class PreQuizScreen : Form
    {
        User thisUser;
        User[] users;

        public PreQuizScreen(User ThisUser, User[] Users)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            picAvatar.BackgroundImage = thisUser.Avatar;
            lblUsername.Text = thisUser.Username;
            lblLevel.Text = Convert.ToString(thisUser.Level);
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            string selectedTopic;
            string selectedDifficulty;

            if((radVocabulary.Checked == true || radGrammar.Checked == true) && (radEasy.Checked == true || radHard.Checked == true))
            {
                if(radVocabulary.Checked == true)
                {
                    selectedTopic = "vocab";
                }
                else
                {
                    selectedTopic = "grammar";
                }

                if(radEasy.Checked == true)
                {
                    selectedDifficulty = "easy";
                }
                else
                {
                    selectedDifficulty = "hard";
                }

                MessageBox.Show("You are about to begin a timed quiz. The points recieved for each correct answer will depend on how much time is left on the timer; more points are awarded for clicking submit faster. If the timer runs out, your current answers will be submitted. An extra 200 points will be awarded to those who complete the quiz on hard mode. For more help, use the help option on the menu strip at the top.");
                this.Hide();
                Form Form1 = new TextBoxFramework(thisUser, users, selectedDifficulty, selectedTopic);
                Form1.Show();
            }
            else
            {
                lblNotSelected.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new MenuScreen(thisUser, users);
            Form1.Show();
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

        private void leaderboardScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new LeaderboardScreenHelp();
            Form1.Show();
        }

        private void profileScreenToolStripMenuItem_Click(object sender, EventArgs e)
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