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
    public partial class LoginScreenHelp : Form
    {
        public LoginScreenHelp()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnMenuScreenHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new MenuScreenHelp();
            Form1.Show();
        }

        private void btnQuizSelectScreenHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new QuizSelectScreenHelp();
            Form1.Show();
        }

        private void btnQuizHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new QuizHelpMenu();
            Form1.Show();
        }

        private void btnResultsScreenHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new ResultsScreenHelp();
            Form1.Show();
        }

        private void btnLeaderboardScreenHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new LeaderboardScreenHelp();
            Form1.Show();
        }

        private void btnProfileScreenHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new ProfileScreenHelp();
            Form1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTextBoxHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new QuizTextBoxHelp();
            Form1.Show();
        }

        private void btnDropDownHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new QuizDropDownHelp();
            Form1.Show();
        }

        private void btnRadioButtonsHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new QuizRadioButtonsHelp();
            Form1.Show();
        }

        private void btnDragAndDropHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new QuizDragAndDropHelp();
            Form1.Show();
        }
    }
}
