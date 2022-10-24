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
    public partial class LoginScreen : Form
    {
        User thisUser = new User();
        User admin = new User();
        User[] users;
        bool createFileFlag = false;
        bool avatarSelected = false;
        bool textJustChanged = false;
        bool createAccountBool;
        bool passwordReq2Met = false;
        private readonly object Form1;

        public LoginScreen()
        {
            InitializeComponent();

            this.CenterToScreen();
            ReadFromFile();
        }

        private void picAvatar1_Click(object sender, EventArgs e)
        {
            thisUser.Avatar = picAvatar1.BackgroundImage;
            lblAvatar1Selected.Visible = true;
            lblAvatar2Selected.Visible = false;
            lblAvatar3Selected.Visible = false;
            avatarSelected = true;
        }

        private void picAvatar2_Click(object sender, EventArgs e)
        {
            thisUser.Avatar = picAvatar2.BackgroundImage;
            lblAvatar2Selected.Visible = true;
            lblAvatar1Selected.Visible = false;
            lblAvatar3Selected.Visible = false;
            avatarSelected = true;
        }

        private void picAvatar3_Click(object sender, EventArgs e)
        {
            thisUser.Avatar = picAvatar3.BackgroundImage;
            lblAvatar3Selected.Visible = true;
            lblAvatar1Selected.Visible = false;
            lblAvatar2Selected.Visible = false;
            avatarSelected = true;
        }

        private void txtRegPassword_TextChanged(object sender, EventArgs e)
        {
            textJustChanged = true;
            ExceptionLabelSetter();
        }

        private bool RegisterExceptionCaller()
        {
            createAccountBool = true;
            string[] allInts = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //This string encompasses every digit

            if (textJustChanged == false)
            {
                foreach (User user in users) //Checks every user
                {
                    if (txtRegUsername.Text == user.Username && txtRegPassword.Text == user.Password)
                    {
                        throw new RegisterExceptionAccountExists("Account already exists");
                    }
                    else if (txtRegUsername.Text == user.Username)
                    {
                        throw new RegisterExceptionUsernameExists("Username already exixts");
                    }
                }

                if (txtRegPasswordAgain.Text != txtRegPassword.Text)
                {
                    throw new RegisterExceptionNotMatchingPasswords("Passwords do not match");
                }

                if (txtRegUsername.Text == String.Empty || txtRegPassword.Text == String.Empty || txtRegPasswordAgain.Text == String.Empty)
                {
                    throw new RegisterExceptionDetailsNotCompleted("Username and/or password text boxes are not filled in");
                }

                if (avatarSelected == false) //I felt that need to give this its own exception and message, as I have found in my testing that many users don't notice the avatars
                {
                    throw new RegisterExceptionDetailsNotCompleted("Avatar has not been selected");
                }

                if (txtRegPassword.Text.Length < 8)
                {
                    throw new RegisterExceptionPasswordInsufficient("Your password does not meet the requirements listed above");
                }

                if (passwordReq2Met == false)
                {
                    throw new RegisterExceptionPasswordInsufficient("Your password does not meet the requirements listed above");
                }
            }
            else
            {
                if (txtRegPassword.Text.Length >= 8)
                {
                    lblRegPasswordReq1.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblRegPasswordReq1.ForeColor = System.Drawing.Color.Red;
                }

                for (int i = 0; i < allInts.Length; i++)
                {
                    if (!txtRegPassword.Text.Contains(allInts[i])) //If txtRegPassword.Text doesn't contain a number
                    {
                        lblRegPasswordReq2.ForeColor = System.Drawing.Color.Red;
                        passwordReq2Met = false;
                    }
                }

                for (int i = 0; i < allInts.Length; i++)
                {
                    if (txtRegPassword.Text.Contains(allInts[i])) //If txtRegPassword.Text contains a number
                    {
                        lblRegPasswordReq2.ForeColor = System.Drawing.Color.Green;
                        passwordReq2Met = true;
                    }
                }

                textJustChanged = false;
            }

            return false;
        }

        private void ExceptionLabelSetter()
        {
            try
            {
                RegisterExceptionCaller();
            }
            catch (RegisterExceptionAccountExists y)
            {
                lblRegInvalidDetails.Text = y.Message;
                createAccountBool = false;
            }
            catch (RegisterExceptionUsernameExists y)
            {
                lblRegInvalidDetails.Text = y.Message;
                createAccountBool = false;
            }
            catch (RegisterExceptionNotMatchingPasswords y)
            {
                lblRegInvalidDetails.Text = y.Message;
                createAccountBool = false;
            }
            catch (RegisterExceptionDetailsNotCompleted y)
            {
                lblRegInvalidDetails.Text = y.Message;
                createAccountBool = false;
            }
            catch (RegisterExceptionPasswordInsufficient y)
            {
                lblRegInvalidDetails.Text = y.Message;
                createAccountBool = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRegEnter_Click(object sender, EventArgs e)
        {
            ExceptionLabelSetter();

            if (createAccountBool == true)
            {
                thisUser.Username = txtRegUsername.Text;
                thisUser.Password = txtRegPassword.Text;

                this.Hide();
                Form Form1 = new MenuScreen(thisUser, users); //Create instance of Form1 and pass it the object thisUser
                Form1.Show();

                if (createFileFlag == false) //If the file already exists we want to add an element to the array for the new player
                {
                    Array.Resize(ref users, users.Length + 1);
                }
                users[users.Length - 1] = thisUser; //Add the player object to the new element in the array
                Stream sw;
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    sw = File.OpenWrite("Users.bin"); //Using openwrite will append to the file rather than overwriting
                    bf.Serialize(sw, users);
                    sw.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                createFileFlag = false; //Set the create flag to be false as if we have got to this stage then the file exists
                                        //If we don't do this and we keep creating new players they won't be written to the array
                ReadFromFile();
            }
        }

        private void ReadFromFile()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if (File.Exists("Users.bin"))
                {

                    sr = File.OpenRead("Users.bin");
                    users = (User[])bf.Deserialize(sr);
                    sr.Close();
                }
                else
                {
                    sr = File.Create("Users.bin");
                    users = new User[1]; //If the file doesn't exist, the array won't be set to the size of array in the file so we must give it a size
                    admin.Username = "Admin";
                    admin.Password = "admin";
                    admin.Avatar = picAvatar1.Image;
                    users[0] = admin;
                    bf.Serialize(sr, users);
                    sr.Close();
                }
                sr = File.OpenRead("Users.bin");
                users = (User[])bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                createFileFlag = true;
                MessageBox.Show(ex.Message);
            }
            Array.Reverse(users);
        }

        private void chkRegShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtRegPassword.PasswordChar == '*') //If the password character is '*' and show password is clicked, the password character is changed to the actual characters input
            {
                txtRegPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegPassword.PasswordChar = '*';
            }

            if (txtRegPasswordAgain.PasswordChar == '*')
            {
                txtRegPasswordAgain.PasswordChar = '\0';
            }
            else
            {
                txtRegPasswordAgain.PasswordChar = '*';
            }
        }

        private void chkLogShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLogPassword.PasswordChar == '*')
            {
                txtLogPassword.PasswordChar = '\0';
            }
            else
            {
                txtLogPassword.PasswordChar = '*';
            }
        }

        private void btnLogEnter_Click(object sender, EventArgs e)
        {
            bool logUserFound = false;
            foreach (User user in users)
            {
                if (user.Username == txtLogUsername.Text && user.Password == txtLogPassword.Text)
                {
                    logUserFound = true;
                    thisUser.Username = user.Username;
                    thisUser.Password = user.Password;
                    //thisUser.Avatar = user.Avatar;
                    thisUser.Highscore = user.Highscore;
                    thisUser.Xp = user.Xp;
                    thisUser.Level = user.Level;
                    thisUser.MaxXp = user.MaxXp;
                    thisUser.QuestionsAsked = user.QuestionsAsked;
                    this.Hide();
                    Form Form1 = new MenuScreen(thisUser, users); //Create instance of Form1 and pass it the object thisUser
                    Form1.Show();
                }
            }


            if (logUserFound == false)
            {
                lblLogInvalidDetailsMessage.Visible = true;
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

        private void btnCodeComplexities_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CodeComplexities.odt");
        }

        private void btnQuizAnswers_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("AnswersDocument.docx");
        }
    }
}