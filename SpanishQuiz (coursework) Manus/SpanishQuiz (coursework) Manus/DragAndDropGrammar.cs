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
    public partial class DragAndDropGrammar : Form
    {
        User thisUser;
        User[] users;
        string selectedDifficulty;
        string selectedTopic;
        public static String selectedDrg;
        Label selectedLabel;
        public static int tempScore;
        bool escribirCorrect = false;
        bool ayudarCorrect = false;
        bool caerCorrect = false;
        bool pelearCorrect = false;
        int seconds = 30;

        public DragAndDropGrammar(User ThisUser, User[] Users, string SelectedDifficulty, string SelectedTopic)
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

        private void DragAndDropGrammar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            drgTopEscribir.AllowDrop = true;
            drgTopAyudar.AllowDrop = true;
            drgTopCaer.AllowDrop = true;
            drgTopPelear.AllowDrop = true;
            drgBottomPelear.AllowDrop = true;
            drgBottomCaer.AllowDrop = true;
            drgBottomAyudar.AllowDrop = true;
            drgBottomEscribir.AllowDrop = true;
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

        private void drgTopEscribir_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopEscribir.Tag.ToString();
            selectedLabel = drgTopEscribir;
            drgTopEscribir.DoDragDrop(drgTopEscribir.Text, DragDropEffects.Copy);
        }

        private void drgTopAyudar_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopAyudar.Tag.ToString();
            selectedLabel = drgTopAyudar;
            drgTopAyudar.DoDragDrop(drgTopAyudar.Text, DragDropEffects.Copy);
        }

        private void drgTopCaer_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopCaer.Tag.ToString();
            selectedLabel = drgTopCaer;
            drgTopCaer.DoDragDrop(drgTopCaer.Text, DragDropEffects.Copy);
        }

        private void drgTopPelear_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDrg = drgTopPelear.Tag.ToString();
            selectedLabel = drgTopPelear;
            drgTopPelear.DoDragDrop(drgTopPelear.Text, DragDropEffects.Copy);
        }

        private void drgBottomPelear_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomPelear.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomPelear.AllowDrop = false;
            if (selectedDrg == drgBottomPelear.Tag.ToString())
            {
                selectedDrg = String.Empty;
                pelearCorrect = true;
            }
        }

        private void drgBottomCaer_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomCaer.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomCaer.AllowDrop = false;
            if (selectedDrg == drgBottomCaer.Tag.ToString())
            {
                selectedDrg = String.Empty;
                caerCorrect = true;
            }
        }

        private void drgBottomAyudar_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomAyudar.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomAyudar.AllowDrop = false;
            if (selectedDrg == drgBottomAyudar.Tag.ToString())
            {
                selectedDrg = String.Empty;
                ayudarCorrect = true;
            }
        }

        private void drgBottomEscribir_DragDrop(object sender, DragEventArgs e)
        {
            drgBottomEscribir.Visible = false;
            selectedLabel.Enabled = false;
            drgBottomEscribir.AllowDrop = false;
            if (selectedDrg == drgBottomEscribir.Tag.ToString())
            {
                selectedDrg = String.Empty;
                escribirCorrect = true;
            }
        }

        private void drgBottomPelear_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void drgBottomCaer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void drgBottomAyudar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void drgBottomEscribir_DragEnter(object sender, DragEventArgs e)
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

            drgBottomPelear.Visible = true;
            drgBottomCaer.Visible = true;
            drgBottomAyudar.Visible = true;
            drgBottomEscribir.Visible = true;

            drgTopEscribir.Enabled = false;
            drgTopAyudar.Enabled = false;
            drgTopCaer.Enabled = false;
            drgTopPelear.Enabled = false;

            drgTopEscribir.Cursor = DefaultCursor;
            drgTopAyudar.Cursor = DefaultCursor;
            drgTopCaer.Cursor = DefaultCursor;
            drgTopPelear.Cursor = DefaultCursor;

            drgTopEscribir.Location = new Point(606, 143);
            drgTopEscribir.ForeColor = System.Drawing.Color.Green;

            drgTopAyudar.Location = new Point(431, 143);
            drgTopAyudar.ForeColor = System.Drawing.Color.Green;

            drgTopCaer.Location = new Point(256, 143);
            drgTopCaer.ForeColor = System.Drawing.Color.Green;

            drgTopPelear.Location = new Point(81, 143);
            drgTopPelear.ForeColor = System.Drawing.Color.Green;

            if (escribirCorrect == true)
            {
                pic1.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic5.Visible = true;
            }

            if (ayudarCorrect == true)
            {
                pic2.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic6.Visible = true;
            }

            if (caerCorrect == true)
            {
                pic3.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic7.Visible = true;
            }

            if (pelearCorrect == true)
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

            pelearCorrect = false;
            ayudarCorrect = false;
            escribirCorrect = false;
            caerCorrect = false;

            drgTopEscribir.Enabled = true;
            drgTopAyudar.Enabled = true;
            drgTopCaer.Enabled = true;
            drgTopPelear.Enabled = true;

            drgBottomPelear.Visible = true;
            drgBottomCaer.Visible = true;
            drgBottomAyudar.Visible = true;
            drgBottomEscribir.Visible = true;

            drgTopEscribir.AllowDrop = true;
            drgTopAyudar.AllowDrop = true;
            drgTopCaer.AllowDrop = true;
            drgTopPelear.AllowDrop = true;
            drgBottomPelear.AllowDrop = true;
            drgBottomCaer.AllowDrop = true;
            drgBottomAyudar.AllowDrop = true;
            drgBottomEscribir.AllowDrop = true;
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
