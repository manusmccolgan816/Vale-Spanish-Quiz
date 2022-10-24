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
    public partial class QuizHelpMenu : Form
    {
        public QuizHelpMenu()
        {
            InitializeComponent();

            this.CenterToScreen();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
