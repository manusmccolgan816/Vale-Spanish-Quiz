namespace SpanishQuiz__coursework__Manus
{
    partial class PreQuizScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.panTopic = new System.Windows.Forms.Panel();
            this.radGrammar = new System.Windows.Forms.RadioButton();
            this.radVocabulary = new System.Windows.Forms.RadioButton();
            this.panDifficulty = new System.Windows.Forms.Panel();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.lblNotSelected = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizSelectScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsScreenTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areYouSureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.loginScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTopic.SuspendLayout();
            this.panDifficulty.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.MediumBlue;
            this.btnStartQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(647, 424);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(150, 75);
            this.btnStartQuiz.TabIndex = 35;
            this.btnStartQuiz.Text = "Start quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 75);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.Transparent;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(5, 1);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(102, 39);
            this.lblTopic.TabIndex = 37;
            this.lblTopic.Text = "Topic";
            // 
            // panTopic
            // 
            this.panTopic.BackColor = System.Drawing.Color.Transparent;
            this.panTopic.Controls.Add(this.radGrammar);
            this.panTopic.Controls.Add(this.lblTopic);
            this.panTopic.Controls.Add(this.radVocabulary);
            this.panTopic.Location = new System.Drawing.Point(512, 206);
            this.panTopic.Name = "panTopic";
            this.panTopic.Size = new System.Drawing.Size(133, 99);
            this.panTopic.TabIndex = 40;
            // 
            // radGrammar
            // 
            this.radGrammar.AutoSize = true;
            this.radGrammar.BackColor = System.Drawing.Color.Transparent;
            this.radGrammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGrammar.Location = new System.Drawing.Point(12, 69);
            this.radGrammar.Name = "radGrammar";
            this.radGrammar.Size = new System.Drawing.Size(82, 20);
            this.radGrammar.TabIndex = 42;
            this.radGrammar.TabStop = true;
            this.radGrammar.Text = "Grammar";
            this.radGrammar.UseVisualStyleBackColor = false;
            // 
            // radVocabulary
            // 
            this.radVocabulary.AutoSize = true;
            this.radVocabulary.BackColor = System.Drawing.Color.Transparent;
            this.radVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVocabulary.Location = new System.Drawing.Point(12, 43);
            this.radVocabulary.Name = "radVocabulary";
            this.radVocabulary.Size = new System.Drawing.Size(95, 20);
            this.radVocabulary.TabIndex = 41;
            this.radVocabulary.TabStop = true;
            this.radVocabulary.Text = "Vocabulary";
            this.radVocabulary.UseVisualStyleBackColor = false;
            // 
            // panDifficulty
            // 
            this.panDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.panDifficulty.Controls.Add(this.radHard);
            this.panDifficulty.Controls.Add(this.lblDifficulty);
            this.panDifficulty.Controls.Add(this.radEasy);
            this.panDifficulty.Location = new System.Drawing.Point(168, 206);
            this.panDifficulty.Name = "panDifficulty";
            this.panDifficulty.Size = new System.Drawing.Size(158, 99);
            this.panDifficulty.TabIndex = 41;
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.BackColor = System.Drawing.Color.Transparent;
            this.radHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHard.Location = new System.Drawing.Point(9, 69);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(56, 20);
            this.radHard.TabIndex = 42;
            this.radHard.TabStop = true;
            this.radHard.Text = "Hard";
            this.radHard.UseVisualStyleBackColor = false;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(2, 1);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(151, 39);
            this.lblDifficulty.TabIndex = 37;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.BackColor = System.Drawing.Color.Transparent;
            this.radEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEasy.Location = new System.Drawing.Point(9, 43);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(57, 20);
            this.radEasy.TabIndex = 41;
            this.radEasy.TabStop = true;
            this.radEasy.Text = "Easy";
            this.radEasy.UseVisualStyleBackColor = false;
            // 
            // lblNotSelected
            // 
            this.lblNotSelected.AutoSize = true;
            this.lblNotSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblNotSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotSelected.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNotSelected.Location = new System.Drawing.Point(413, 478);
            this.lblNotSelected.Name = "lblNotSelected";
            this.lblNotSelected.Size = new System.Drawing.Size(228, 18);
            this.lblNotSelected.TabIndex = 42;
            this.lblNotSelected.Text = "Please select a topic and difficulty";
            this.lblNotSelected.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsername.Location = new System.Drawing.Point(696, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 16);
            this.lblUsername.TabIndex = 44;
            this.lblUsername.Text = "lblUsername";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginScreenHelpToolStripMenuItem,
            this.menuScreenToolStripMenuItem,
            this.quizSelectScreenToolStripMenuItem,
            this.quizTutorialToolStripMenuItem,
            this.resultsScreenTutorialToolStripMenuItem,
            this.leaderboardScreenToolStripMenuItem,
            this.profileScreenToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuScreenToolStripMenuItem
            // 
            this.menuScreenToolStripMenuItem.Name = "menuScreenToolStripMenuItem";
            this.menuScreenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.menuScreenToolStripMenuItem.Text = "Menu screen help";
            this.menuScreenToolStripMenuItem.Click += new System.EventHandler(this.menuScreenToolStripMenuItem_Click);
            // 
            // quizSelectScreenToolStripMenuItem
            // 
            this.quizSelectScreenToolStripMenuItem.Name = "quizSelectScreenToolStripMenuItem";
            this.quizSelectScreenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.quizSelectScreenToolStripMenuItem.Text = "Quiz select screen help";
            this.quizSelectScreenToolStripMenuItem.Click += new System.EventHandler(this.quizSelectScreenToolStripMenuItem_Click);
            // 
            // quizTutorialToolStripMenuItem
            // 
            this.quizTutorialToolStripMenuItem.Name = "quizTutorialToolStripMenuItem";
            this.quizTutorialToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.quizTutorialToolStripMenuItem.Text = "Quiz help";
            this.quizTutorialToolStripMenuItem.Click += new System.EventHandler(this.quizTutorialToolStripMenuItem_Click);
            // 
            // resultsScreenTutorialToolStripMenuItem
            // 
            this.resultsScreenTutorialToolStripMenuItem.Name = "resultsScreenTutorialToolStripMenuItem";
            this.resultsScreenTutorialToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resultsScreenTutorialToolStripMenuItem.Text = "Results screen help";
            this.resultsScreenTutorialToolStripMenuItem.Click += new System.EventHandler(this.resultsScreenTutorialToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areYouSureToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // areYouSureToolStripMenuItem
            // 
            this.areYouSureToolStripMenuItem.Name = "areYouSureToolStripMenuItem";
            this.areYouSureToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.areYouSureToolStripMenuItem.Text = "Exit program";
            this.areYouSureToolStripMenuItem.Click += new System.EventHandler(this.areYouSureToolStripMenuItem_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Location = new System.Drawing.Point(699, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(110, 110);
            this.picAvatar.TabIndex = 46;
            this.picAvatar.TabStop = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.DarkRed;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(784, 7);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(18, 20);
            this.lblLevel.TabIndex = 48;
            this.lblLevel.Tag = "";
            this.lblLevel.Text = "1";
            // 
            // loginScreenHelpToolStripMenuItem
            // 
            this.loginScreenHelpToolStripMenuItem.Name = "loginScreenHelpToolStripMenuItem";
            this.loginScreenHelpToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loginScreenHelpToolStripMenuItem.Text = "Login screen help";
            this.loginScreenHelpToolStripMenuItem.Click += new System.EventHandler(this.loginScreenHelpToolStripMenuItem_Click);
            // 
            // leaderboardScreenToolStripMenuItem
            // 
            this.leaderboardScreenToolStripMenuItem.Name = "leaderboardScreenToolStripMenuItem";
            this.leaderboardScreenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.leaderboardScreenToolStripMenuItem.Text = "Leaderboard screen help";
            this.leaderboardScreenToolStripMenuItem.Click += new System.EventHandler(this.leaderboardScreenToolStripMenuItem_Click);
            // 
            // profileScreenToolStripMenuItem
            // 
            this.profileScreenToolStripMenuItem.Name = "profileScreenToolStripMenuItem";
            this.profileScreenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.profileScreenToolStripMenuItem.Text = "Profile screen help";
            this.profileScreenToolStripMenuItem.Click += new System.EventHandler(this.profileScreenToolStripMenuItem_Click);
            // 
            // PreQuizScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpanishQuiz__coursework__Manus.Properties.Resources.SpanFlag2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblNotSelected);
            this.Controls.Add(this.panDifficulty);
            this.Controls.Add(this.panTopic);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStartQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PreQuizScreen";
            this.Text = "Vale ~ Quiz select screen";
            this.panTopic.ResumeLayout(false);
            this.panTopic.PerformLayout();
            this.panDifficulty.ResumeLayout(false);
            this.panDifficulty.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Panel panTopic;
        private System.Windows.Forms.RadioButton radGrammar;
        private System.Windows.Forms.RadioButton radVocabulary;
        private System.Windows.Forms.Panel panDifficulty;
        private System.Windows.Forms.RadioButton radHard;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.Label lblNotSelected;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizSelectScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsScreenTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ToolStripMenuItem loginScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileScreenToolStripMenuItem;
    }
}