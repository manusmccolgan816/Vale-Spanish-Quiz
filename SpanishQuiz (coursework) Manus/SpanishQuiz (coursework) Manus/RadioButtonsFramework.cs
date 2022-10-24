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
    public partial class RadioButtonsFramework : Form
    {
        User thisUser;
        User[] users;
        string file_name;
        string selectedDifficuly;
        string selectedTopic;
        List<Questions> arrayList = new List<Questions>();
        int[] dummyArray;
        int[] randomNum = new int[3];
        int seconds = 40;
        int clearingQuestionsAskedCounter = 0;

        public RadioButtonsFramework(User ThisUser, User[] Users, string File_name, string SelectedDifficulty, string SelectedTopic)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            file_name = File_name;
            selectedDifficuly = SelectedDifficulty;
            selectedTopic = SelectedTopic;
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            lblScore.Text = Convert.ToString(thisUser.Score);

            LoadingQuestions();
        }

        private void RadioButtonsFramework_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void PopulatingArray(int lengthOfArray)
        {
            for (int i = 0; i < lengthOfArray; i++)
            {
                dummyArray[i] = -1;
            }
        }

        private void LoadingQuestions()
        {

            int lengthOfArray;
            int crashCtr = 1;
            System.IO.StreamReader objReader;
            objReader = new System.IO.StreamReader(file_name);
            try
            {
                for (int i = 0; i < crashCtr; i++)
                {
                    int questionNumber = int.Parse(objReader.ReadLine());
                    String question = objReader.ReadLine();
                    String answer1 = objReader.ReadLine();
                    String answer2 = objReader.ReadLine();
                    String answer3 = objReader.ReadLine();
                    String answer4 = objReader.ReadLine();
                    String answer5 = objReader.ReadLine();
                    String answer6 = objReader.ReadLine();
                    string correctAnswer = objReader.ReadLine();
                    arrayList.Add(new Questions(questionNumber, question, answer1, answer2, answer3, answer4, answer5, answer6, correctAnswer));
                    crashCtr++;
                }
            }
            catch (Exception)
            {
                //Nothing needs to happen here
            }

            lengthOfArray = arrayList.Count();
            dummyArray = new int[lengthOfArray];

            PopulatingArray(lengthOfArray);

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Random rnd = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd.Next(lengthOfArray);
                        if (clearingQuestionsAskedCounter == 50) //If the loop has been run 50 times (meaning the user has experienced every question)
                        {
                            for (int j = 0; j < 50; j++)
                            {
                                thisUser.QuestionsAsked[2, j] = -1; //Set every element of the third row of thisUser.QuestionsAsked back to -1, ensuring that the do while loop is broken out of
                            }
                        }
                        clearingQuestionsAskedCounter++;

                    } while (dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[2, randomElement] != -1);

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1;
                    thisUser.QuestionsAsked[2, randomElement] = 1;
                    lblQ1.Text = arrayList[randomElement].Question;
                    lblQ1CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer;
                    rad1Q1.Text = arrayList[randomElement].Answer1;
                    rad2Q1.Text = arrayList[randomElement].Answer2;
                    rad3Q1.Text = arrayList[randomElement].Answer3;
                    rad4Q1.Text = arrayList[randomElement].Answer4;
                    rad5Q1.Text = arrayList[randomElement].Answer5;
                    rad6Q1.Text = arrayList[randomElement].Answer6;
                }
                else if (i == 1)
                {
                    Random rnd = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd.Next(lengthOfArray);

                    } while (dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[2, randomElement] != -1);

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1;
                    thisUser.QuestionsAsked[2, randomElement] = 1;
                    lblQ2.Text = arrayList[randomElement].Question;
                    lblQ2CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer;
                    rad1Q2.Text = arrayList[randomElement].Answer1;
                    rad2Q2.Text = arrayList[randomElement].Answer2;
                    rad3Q2.Text = arrayList[randomElement].Answer3;
                    rad4Q2.Text = arrayList[randomElement].Answer4;
                    rad5Q2.Text = arrayList[randomElement].Answer5;
                    rad6Q2.Text = arrayList[randomElement].Answer6;
                }
                else if (i == 2)
                {
                    Random rnd = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd.Next(lengthOfArray);

                    } while (dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[2, randomElement] != -1);

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1;
                    thisUser.QuestionsAsked[2, randomElement] = 1;
                    lblQ3.Text = arrayList[randomElement].Question;
                    lblQ3CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer;
                    rad1Q3.Text = arrayList[randomElement].Answer1;
                    rad2Q3.Text = arrayList[randomElement].Answer2;
                    rad3Q3.Text = arrayList[randomElement].Answer3;
                    rad4Q3.Text = arrayList[randomElement].Answer4;
                    rad5Q3.Text = arrayList[randomElement].Answer5;
                    rad6Q3.Text = arrayList[randomElement].Answer6;
                }
            }
        }

        private void ScoreMultiplier()
        {
            if (Convert.ToInt16(lblSeconds.Text) >= 30)
            {
                thisUser.Score += 200;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 25 && Convert.ToInt16(lblSeconds.Text) < 30)
            {
                thisUser.Score += 180;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 20 && Convert.ToInt16(lblSeconds.Text) < 25)
            {
                thisUser.Score += 160;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 15 && Convert.ToInt16(lblSeconds.Text) < 20)
            {
                thisUser.Score += 140;
            }
            else if (Convert.ToInt16(lblSeconds.Text) >= 10 && Convert.ToInt16(lblSeconds.Text) < 15)
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

            btnSubmit.Enabled = false;
            btnNext.Enabled = true;
            panQ1.Enabled = false;
            panQ2.Enabled = false;
            panQ3.Enabled = false;

            bool q1Correct = false;
            bool q2Correct = false;
            bool q3Correct = false;

            if (rad1Q1.Text == arrayList[randomNum[0]].CorrectAnswer)
            {
                if (rad1Q1.Checked == true)
                {
                    q1Correct = true;
                }
            }
            else if (rad2Q1.Text == arrayList[randomNum[0]].CorrectAnswer)
            {
                if (rad2Q1.Checked == true)
                {
                    q1Correct = true;
                }
            }
            else if (rad3Q1.Text == arrayList[randomNum[0]].CorrectAnswer)
            {
                if (rad3Q1.Checked == true)
                {
                    q1Correct = true;
                }
            }
            else if (rad4Q1.Text == arrayList[randomNum[0]].CorrectAnswer)
            {
                if (rad4Q1.Checked == true)
                {
                    q1Correct = true;
                }
            }
            else if (rad5Q1.Text == arrayList[randomNum[0]].CorrectAnswer)
            {
                if (rad5Q1.Checked == true)
                {
                    q1Correct = true;
                }
            }
            else if (rad6Q1.Text == arrayList[randomNum[0]].CorrectAnswer)
            {
                if (rad6Q1.Checked == true)
                {
                    q1Correct = true;
                }
            }

            if (rad1Q2.Text == arrayList[randomNum[1]].CorrectAnswer)
            {
                if (rad1Q2.Checked == true)
                {
                    q2Correct = true;
                }
            }
            else if (rad2Q2.Text == arrayList[randomNum[1]].CorrectAnswer)
            {
                if (rad2Q2.Checked == true)
                {
                    q2Correct = true;
                }
            }
            else if (rad3Q2.Text == arrayList[randomNum[1]].CorrectAnswer)
            {
                if (rad3Q2.Checked == true)
                {
                    q2Correct = true;
                }
            }
            else if (rad4Q2.Text == arrayList[randomNum[1]].CorrectAnswer)
            {
                if (rad4Q2.Checked == true)
                {
                    q2Correct = true;
                }
            }
            else if (rad5Q2.Text == arrayList[randomNum[1]].CorrectAnswer)
            {
                if (rad5Q2.Checked == true)
                {
                    q2Correct = true;
                }
            }
            else if (rad6Q2.Text == arrayList[randomNum[1]].CorrectAnswer)
            {
                if (rad6Q2.Checked == true)
                {
                    q2Correct = true;
                }
            }

            if (rad1Q3.Text == arrayList[randomNum[2]].CorrectAnswer)
            {
                if (rad1Q3.Checked == true)
                {
                    q3Correct = true;
                }
            }
            else if (rad2Q3.Text == arrayList[randomNum[2]].CorrectAnswer)
            {
                if (rad2Q3.Checked == true)
                {
                    q3Correct = true;
                }
            }
            else if (rad3Q3.Text == arrayList[randomNum[2]].CorrectAnswer)
            {
                if (rad3Q3.Checked == true)
                {
                    q3Correct = true;
                }
            }
            else if (rad4Q3.Text == arrayList[randomNum[2]].CorrectAnswer)
            {
                if (rad4Q3.Checked == true)
                {
                    q3Correct = true;
                }
            }
            else if (rad5Q3.Text == arrayList[randomNum[2]].CorrectAnswer)
            {
                if (rad5Q3.Checked == true)
                {
                    q3Correct = true;
                }
            }
            else if (rad6Q3.Text == arrayList[randomNum[2]].CorrectAnswer)
            {
                if (rad6Q3.Checked == true)
                {
                    q3Correct = true;
                }
            }

            if (q1Correct == true)
            {
                pic1.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic4.Visible = true;
                lblQ1CorrectAnswer.Visible = true;
            }

            if (q2Correct == true)
            {
                pic2.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic5.Visible = true;
                lblQ2CorrectAnswer.Visible = true;
            }

            if (q3Correct == true)
            {
                pic3.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic6.Visible = true;
                lblQ3CorrectAnswer.Visible = true;
            }

            lblScore.Text = Convert.ToString(thisUser.Score);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitAnswers();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(selectedTopic == "vocab")
            {
                this.Hide();
                Form Form1 = new DragAndDropVocab(thisUser, users, selectedDifficuly, selectedTopic);
                Form1.Show();
            }
            else
            {
                this.Hide();
                Form Form1 = new DragAndDropGrammar(thisUser, users, selectedDifficuly, selectedTopic);
                Form1.Show();
            }
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