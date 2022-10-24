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
    public partial class DragAndDropVocab : Form
    {
        User thisUser;
        User[] users;
        string selectedDifficulty;
        string selectedTopic;
        public static String selectedDrg;
        Label selectedLabel;
        public static int tempScore;
        bool baloncestoCorrect = false;
        bool equitaciónCorrect = false;
        bool esquíCorrect = false;
        bool puentingCorrect = false;
        int seconds = 30;

        public DragAndDropVocab(User ThisUser, User[] Users, string SelectedDifficulty, string SelectedTopic)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            selectedDifficulty = SelectedDifficulty;
            selectedTopic = SelectedTopic;
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            lblScore.Text = Convert.ToString(thisUser.Score);
        }

        private void DragAndDrop_Load(object sender, EventArgs e)
        {
            timer1.Start();
            drgTopBaloncesto.AllowDrop = true;
            drgTopEquitación.AllowDrop = true;
            drgTopEsquí.AllowDrop = true;
            drgTopPuenting.AllowDrop = true;
            drgBottomBaloncesto.AllowDrop = true;
            drgBottomEquitación.AllowDrop = true;
            drgBottomEsquí.AllowDrop = true;
            drgBottomPuenting.AllowDrop = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSeconds.Text = seconds.ToString();

            seconds -= 1;

            if (Convert.ToInt16(lblSeconds.Text) == 0 && Convert.ToInt16(lblMinutes.Text) == 0) //If there is no time left on the clock, the answers are submitted
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time for this question!");
                SubmitAnswers();
            }
        }

        private void drgTopBaloncesto_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopBaloncesto.Tag.ToString();
            selectedLabel = drgTopBaloncesto;
            drgTopBaloncesto.DoDragDrop(drgTopBaloncesto.Text, DragDropEffects.Copy);
        }

        private void drgTopEquitación_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopEquitación.Tag.ToString();
            selectedLabel = drgTopEquitación;
            drgTopEquitación.DoDragDrop(drgTopEquitación.Text, DragDropEffects.Copy);
        }

        private void drgTopEsquí_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopEsquí.Tag.ToString();
            selectedLabel = drgTopEsquí;
            drgTopEsquí.DoDragDrop(drgTopEsquí.Text, DragDropEffects.Copy);
        }

        private void drgTopPuenting_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopPuenting.Tag.ToString();
            selectedLabel = drgTopPuenting;
            drgTopPuenting.DoDragDrop(drgTopPuenting.Text, DragDropEffects.Copy);
        }

        private void drgBottomBaloncesto_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomBaloncesto.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomBaloncesto.AllowDrop = false;
            if (selectedDrg == drgBottomBaloncesto.Tag.ToString())
            {
                selectedDrg = String.Empty;
                baloncestoCorrect = true;
            }
        }

        private void drgBottomEsquí_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomEsquí.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomEsquí.AllowDrop = false;
            if (selectedDrg == drgBottomEsquí.Tag.ToString())
            {
                selectedDrg = String.Empty;
                esquíCorrect = true;
            }
        }

        private void drgBottomPuenting_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomPuenting.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomPuenting.AllowDrop = false;
            if (selectedDrg == drgBottomPuenting.Tag.ToString())
            {
                selectedDrg = String.Empty;
                puentingCorrect = true;
            }
        }

        private void drgBottomEquitación_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomEquitación.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomEquitación.AllowDrop = false;
            if (selectedDrg == drgBottomEquitación.Tag.ToString())
            {
                selectedDrg = String.Empty;
                equitaciónCorrect = true;
            }
        }
        
        private void drgBottomBaloncesto_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void drgBottomEsquí_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void drgBottomPuenting_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void drgBottomEquitación_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ScoreMultiplier()
        {
            if (Convert.ToInt16(lblSeconds.Text) >= 22)
            {
                thisUser.Score += 200;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 18 && Convert.ToInt16(lblSeconds.Text) < 22)
            {
                thisUser.Score += 180;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 14 && Convert.ToInt16(lblSeconds.Text) < 18)
            {
                thisUser.Score += 160;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 10 && Convert.ToInt16(lblSeconds.Text) < 14)
            {
                thisUser.Score += 140;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 6 && Convert.ToInt16(lblSeconds.Text) < 10)
            {
                thisUser.Score += 120;
            }
            else
            {
                thisUser.Score += 100;
            }
        }

        private void SubmitAnswers()
        {
            timer1.Stop();

            btnNext.Enabled = true;
            btnSubmit.Enabled = false;
            btnReset.Enabled = false;

            drgBottomBaloncesto.Visible = true;
            drgBottomEsquí.Visible = true;
            drgBottomPuenting.Visible = true;
            drgBottomEquitación.Visible = true;

            drgTopBaloncesto.Enabled = false;
            drgTopEquitación.Enabled = false;
            drgTopEsquí.Enabled = false;
            drgTopPuenting.Enabled = false;

            drgTopBaloncesto.Cursor = DefaultCursor;
            drgTopEquitación.Cursor = DefaultCursor;
            drgTopEsquí.Cursor = DefaultCursor;
            drgTopPuenting.Cursor = DefaultCursor;

            drgTopBaloncesto.ForeColor = System.Drawing.Color.Green;

            drgTopEquitación.Location = new Point(606, 143);
            drgTopEquitación.ForeColor = System.Drawing.Color.Green;

            drgTopEsquí.Location = new Point(256, 143);
            drgTopEsquí.ForeColor = System.Drawing.Color.Green;

            drgTopPuenting.Location = new Point(431, 143);
            drgTopPuenting.ForeColor = System.Drawing.Color.Green;

            if (baloncestoCorrect == true)
            {
                pic1.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic5.Visible = true;
            }

            if (esquíCorrect == true)
            {
                pic2.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic6.Visible = true;
            }

            if (puentingCorrect == true)
            {
                pic3.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic7.Visible = true;
            }

            if (equitaciónCorrect == true)
            {
                pic4.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic8.Visible = true;
            }

            lblScore.Text = Convert.ToString(thisUser.Score);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitAnswers();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new ResultsScreen(thisUser, users, selectedDifficulty, selectedTopic);
            Form1.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            selectedDrg = "";

            baloncestoCorrect = false;
            esquíCorrect = false;
            puentingCorrect = false;
            equitaciónCorrect = false;

            drgTopBaloncesto.Enabled = true;
            drgTopEsquí.Enabled = true;
            drgTopPuenting.Enabled = true;
            drgTopEquitación.Enabled = true;

            drgBottomBaloncesto.Visible = true;
            drgBottomEsquí.Visible = true;
            drgBottomPuenting.Visible = true;
            drgBottomEquitación.Visible = true;

            drgTopBaloncesto.AllowDrop = true;
            drgTopEsquí.AllowDrop = true;
            drgTopPuenting.AllowDrop = true;
            drgTopEquitación.AllowDrop = true;
            drgBottomBaloncesto.AllowDrop = true;
            drgBottomEsquí.AllowDrop = true;
            drgBottomPuenting.AllowDrop = true;
            drgBottomEquitación.AllowDrop = true;
        }

        private void btnQuitQuiz_Click(object sender, EventArgs e)
        {
            DialogResult exitQuizConfirmation = MessageBox.Show("Are you sure you want to return to the menu screen?", "Exit quiz", MessageBoxButtons.YesNo);

            if (exitQuizConfirmation == DialogResult.Yes)
            {
                thisUser.Score = 0;
                timer1.Stop();

                this.Hide();
                Form Form1 = new MenuScreen(thisUser, users);
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