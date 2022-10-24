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
    public partial class MenuScreen : Form
    {
        User thisUser;
        User[] users;
        string previousForm = "menu";

        public MenuScreen(User ThisUser, User[] Users)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            picAvatar.BackgroundImage = thisUser.Avatar;
            lblUsername.Text = thisUser.Username;
            lblLevel.Text = Convert.ToString(thisUser.Level);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new PreQuizScreen(thisUser, users);
            Form1.Show();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new LeaderboardScreen(thisUser, users, previousForm);
            Form1.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new ProfileScreen(thisUser, users);
            Form1.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logOffConfirmation = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);

            if(logOffConfirmation == DialogResult.Yes)
            {
                thisUser = null;

                this.Hide();
                Form Form1 = new LoginScreen();
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