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
    public partial class TextBoxFramework : Form
    {
        User thisUser;
        User[] users;
        string file_name;
        string selectedDifficulty;
        string selectedTopic;
        List<Questions> arrayList = new List<Questions>();
        int[] dummyArray;
        int[] randomNum = new int[4];
        int seconds = 40;
        int clearingQuestionsAskedCounter = 0;

        public TextBoxFramework(User ThisUser, User[] Users, string SelectedDifficulty, string SelectedTopic)
        {
            InitializeComponent();
            this.CenterToScreen();
            thisUser = ThisUser;
            users = Users;
            selectedDifficulty = SelectedDifficulty;
            selectedTopic = SelectedTopic;
            thisUser.Score = 0; //Score is set to 0 so that the user always starts the quiz with a score of 0
            lblHighscore.Text = Convert.ToString(thisUser.Highscore);
            lblScore.Text = Convert.ToString(thisUser.Score);

            FileNameFinder();
            LoadingQuestions();
        }



        private void TextBoxFramework_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSeconds.Text = seconds.ToString();

            seconds -= 1;

            if(Convert.ToInt16(lblSeconds.Text) == 0 && Convert.ToInt16(lblMinutes.Text) == 0) //If there is no time left on the clock, the answers are submitted
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time for this question!");
                SubmitAnswers();
            }
        }

        private void FileNameFinder()
        {
            if (selectedTopic == "vocab")
            {
                if (selectedDifficulty == "easy")
                {
                    file_name = "VocabQuestions\\EasyQuestions\\TextBoxQuestions.txt";
                }
                else
                {
                    file_name = "VocabQuestions\\HardQuestions\\TextBoxQuestions.txt";
                }
            }
            else
            {
                if (selectedDifficulty == "easy")
                {
                    file_name = "GrammarQuestions\\EasyQuestions\\TextBoxQuestions.txt";
                }
                else
                {
                    file_name = "GrammarQuestions\\HardQuestions\\TextBoxQuestions.txt";
                }
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
            int lengthOfArray = 0;
            int crashCtr = 1;

            System.IO.StreamReader objReader;
            objReader = new System.IO.StreamReader(file_name);
            try
            {
                for (int i = 0; i < crashCtr; i++)
                {
                    int questionNo = int.Parse(objReader.ReadLine());
                    String question = objReader.ReadLine();
                    string correctAnswer = objReader.ReadLine();
                    string correctAnswer2 = objReader.ReadLine();
                    arrayList.Add(new Questions(questionNo, question, correctAnswer, correctAnswer2));
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

            for (int i = 0; i < 4; i++)
            {
                if(i == 0)
                {
                    Random rnd1 = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd1.Next(lengthOfArray); //Generate random number between 0 and length of array
                        if(clearingQuestionsAskedCounter == 50) //If the loop has been run 50 times (meaning the user has experienced every question)
                        {
                            for(int j = 0; j < 50; j++)
                            {
                                thisUser.QuestionsAsked[0, j] = -1; //Set every element of the first row of thisUser.QuestionsAsked back to -1, ensuring that the do while loop is broken out of
                            }
                        }
                        clearingQuestionsAskedCounter++;

                    } while (dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[0, randomElement] != -1); //Until one is generated that hasn't been used before

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1; //Now that this random number has been used, change the value in dummyArray so that it can't be used again
                    thisUser.QuestionsAsked[0, randomElement] = 1;
                    lblQ1.Text = arrayList[randomElement].Question;
                    lblQ1CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer.ToLower();
                }
                else if (i == 1)
                {
                    Random rnd1 = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd1.Next(lengthOfArray);

                    } while (dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[0, randomElement] != -1);

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1;
                    thisUser.QuestionsAsked[0, randomElement] = 1;
                    lblQ2.Text = arrayList[randomElement].Question;
                    lblQ2CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer.ToLower();
                }
                else if(i == 2)
                {
                    Random rnd1 = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd1.Next(lengthOfArray);

                    } while (dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[0, randomElement] != -1);

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1;
                    thisUser.QuestionsAsked[0, randomElement] = 1;
                    lblQ3.Text = arrayList[randomElement].Question;
                    lblQ3CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer.ToLower();
                }
                else if(i == 3)
                {
                    Random rnd1 = new Random();
                    int randomElement;
                    do
                    {
                        randomElement = rnd1.Next(lengthOfArray);

                    } while(dummyArray[randomElement] != -1 || thisUser.QuestionsAsked[0, randomElement] != -1);

                    randomNum[i] = randomElement;

                    dummyArray[randomElement] = 1;
                    thisUser.QuestionsAsked[0, randomElement] = 1;
                    lblQ4.Text = arrayList[randomElement].Question;
                    lblQ4CorrectAnswer.Text = arrayList[randomElement].CorrectAnswer.ToLower();
                }
            }
        }

        private void ScoreMultiplier() //In this method, a points are added to the user's score based on how much time is left on the timer
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
            txtQ1.Enabled = false;
            txtQ2.Enabled = false;
            txtQ3.Enabled = false;
            txtQ4.Enabled = false;

            if (txtQ1.Text.ToUpper().Trim() == arrayList[randomNum[0]].CorrectAnswer || txtQ1.Text.ToUpper().Trim() == arrayList[randomNum[0]].CorrectAnswer2)
            {
                pic1.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic5.Visible = true;
                lblQ1CorrectAnswer.Visible = true;
            }

            if (txtQ2.Text.ToUpper().Trim() == arrayList[randomNum[1]].CorrectAnswer || txtQ2.Text.ToUpper().Trim() == arrayList[randomNum[1]].CorrectAnswer2)
            {
                pic2.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic6.Visible = true;
                lblQ2CorrectAnswer.Visible = true;
            }

            if (txtQ3.Text.ToUpper().Trim() == arrayList[randomNum[2]].CorrectAnswer || txtQ3.Text.ToUpper().Trim() == arrayList[randomNum[2]].CorrectAnswer2)
            {
                pic3.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic7.Visible = true;
                lblQ3CorrectAnswer.Visible = true;
            }

            if (txtQ4.Text.ToUpper().Trim() == arrayList[randomNum[3]].CorrectAnswer || txtQ4.Text.ToUpper().Trim() == arrayList[randomNum[3]].CorrectAnswer2)
            {
                pic4.Visible = true;
                ScoreMultiplier();
            }
            else
            {
                pic8.Visible = true;
                lblQ4CorrectAnswer.Visible = true;
            }

            lblScore.Text = Convert.ToString(thisUser.Score);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitAnswers();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedTopic == "vocab")
            {
                if (selectedDifficulty == "easy")
                {
                    file_name = "VocabQuestions\\EasyQuestions\\DropDownQuestions.txt";
                    this.Hide();
                    Form Form1 = new DropDownFramework(thisUser, users, file_name, selectedDifficulty, selectedTopic);
                    Form1.Show();
                }
                else
                {
                    file_name = "VocabQuestions\\HardQuestions\\DropDownQuestions.txt";
                    this.Hide();
                    Form Form1 = new DropDownFramework(thisUser, users, file_name, selectedDifficulty, selectedTopic);
                    Form1.Show();
                }
            }
            else
            {
                if (selectedDifficulty == "easy")
                {
                    file_name = "GrammarQuestions\\EasyQuestions\\DropDownQuestions.txt";
                    this.Hide();
                    Form Form1 = new DropDownFramework(thisUser, users, file_name, selectedDifficulty, selectedTopic);
                    Form1.Show();
                }
                else
                {
                    file_name = "GrammarQuestions\\HardQuestions\\DropDownQuestions.txt";
                    this.Hide();
                    Form Form1 = new DropDownFramework(thisUser, users, file_name, selectedDifficulty, selectedTopic);
                    Form1.Show();
                }
            }
        }

        private void btnQuitQuiz_Click(object sender, EventArgs e)
        {
            DialogResult exitQuizConfirmation = MessageBox.Show("Are you sure you want to return to the menu screen?", "Exit quiz", MessageBoxButtons.YesNo);

            if (exitQuizConfirmation == DialogResult.Yes)
            {
                timer1.Stop();
                thisUser.Score = 0;

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