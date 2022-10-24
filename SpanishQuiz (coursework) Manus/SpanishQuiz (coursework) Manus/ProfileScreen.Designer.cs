namespace SpanishQuiz__coursework__Manus
{
    partial class ProfileScreen
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblUsernameColon = new System.Windows.Forms.Label();
            this.lblHighscoreColon = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizSelectScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsScreenTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areYouSureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblMaxXp = new System.Windows.Forms.Label();
            this.lblMinXp = new System.Windows.Forms.Label();
            this.prgXp = new System.Windows.Forms.ProgressBar();
            this.label3lblExperiencePointsNotValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(329, 278);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 25);
            this.lblUsername.TabIndex = 39;
            this.lblUsername.Text = "lblUsername";
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Location = new System.Drawing.Point(334, 135);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(140, 140);
            this.picAvatar.TabIndex = 38;
            this.picAvatar.TabStop = false;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(329, 303);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(131, 25);
            this.lblHighscore.TabIndex = 40;
            this.lblHighscore.Text = "lblHighscore";
            // 
            // lblUsernameColon
            // 
            this.lblUsernameColon.AutoSize = true;
            this.lblUsernameColon.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameColon.Location = new System.Drawing.Point(216, 278);
            this.lblUsernameColon.Name = "lblUsernameColon";
            this.lblUsernameColon.Size = new System.Drawing.Size(116, 25);
            this.lblUsernameColon.TabIndex = 41;
            this.lblUsernameColon.Text = "Username:";
            // 
            // lblHighscoreColon
            // 
            this.lblHighscoreColon.AutoSize = true;
            this.lblHighscoreColon.BackColor = System.Drawing.Color.Transparent;
            this.lblHighscoreColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscoreColon.Location = new System.Drawing.Point(217, 303);
            this.lblHighscoreColon.Name = "lblHighscoreColon";
            this.lblHighscoreColon.Size = new System.Drawing.Size(115, 25);
            this.lblHighscoreColon.TabIndex = 42;
            this.lblHighscoreColon.Text = "Highscore:";
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
            this.menuStrip1.TabIndex = 43;
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
            this.leaderboardScreenHelpToolStripMenuItem,
            this.profileScreenHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // loginScreenHelpToolStripMenuItem
            // 
            this.loginScreenHelpToolStripMenuItem.Name = "loginScreenHelpToolStripMenuItem";
            this.loginScreenHelpToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loginScreenHelpToolStripMenuItem.Text = "Login screen help";
            this.loginScreenHelpToolStripMenuItem.Click += new System.EventHandler(this.loginScreenHelpToolStripMenuItem_Click);
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
            // leaderboardScreenHelpToolStripMenuItem
            // 
            this.leaderboardScreenHelpToolStripMenuItem.Name = "leaderboardScreenHelpToolStripMenuItem";
            this.leaderboardScreenHelpToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.leaderboardScreenHelpToolStripMenuItem.Text = "Leaderboard screen help";
            this.leaderboardScreenHelpToolStripMenuItem.Click += new System.EventHandler(this.leaderboardScreenHelpToolStripMenuItem_Click);
            // 
            // profileScreenHelpToolStripMenuItem
            // 
            this.profileScreenHelpToolStripMenuItem.Name = "profileScreenHelpToolStripMenuItem";
            this.profileScreenHelpToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.profileScreenHelpToolStripMenuItem.Text = "Profile screen help";
            this.profileScreenHelpToolStripMenuItem.Click += new System.EventHandler(this.profileScreenHelpToolStripMenuItem_Click);
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
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.DarkRed;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(444, 145);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(20, 24);
            this.lblLevel.TabIndex = 47;
            this.lblLevel.Tag = "";
            this.lblLevel.Text = "1";
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.BackColor = System.Drawing.Color.Transparent;
            this.lblXp.Location = new System.Drawing.Point(331, 357);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(15, 16);
            this.lblXp.TabIndex = 56;
            this.lblXp.Text = "0";
            // 
            // lblMaxXp
            // 
            this.lblMaxXp.AutoSize = true;
            this.lblMaxXp.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxXp.Location = new System.Drawing.Point(480, 336);
            this.lblMaxXp.Name = "lblMaxXp";
            this.lblMaxXp.Size = new System.Drawing.Size(43, 16);
            this.lblMaxXp.TabIndex = 55;
            this.lblMaxXp.Text = "10000";
            // 
            // lblMinXp
            // 
            this.lblMinXp.AutoSize = true;
            this.lblMinXp.BackColor = System.Drawing.Color.Transparent;
            this.lblMinXp.Location = new System.Drawing.Point(313, 336);
            this.lblMinXp.Name = "lblMinXp";
            this.lblMinXp.Size = new System.Drawing.Size(15, 16);
            this.lblMinXp.TabIndex = 54;
            this.lblMinXp.Text = "0";
            // 
            // prgXp
            // 
            this.prgXp.Location = new System.Drawing.Point(334, 331);
            this.prgXp.Name = "prgXp";
            this.prgXp.Size = new System.Drawing.Size(140, 23);
            this.prgXp.TabIndex = 53;
            // 
            // label3lblExperiencePointsNotValue
            // 
            this.label3lblExperiencePointsNotValue.AutoSize = true;
            this.label3lblExperiencePointsNotValue.BackColor = System.Drawing.Color.Transparent;
            this.label3lblExperiencePointsNotValue.Location = new System.Drawing.Point(214, 357);
            this.label3lblExperiencePointsNotValue.Name = "label3lblExperiencePointsNotValue";
            this.label3lblExperiencePointsNotValue.Size = new System.Drawing.Size(118, 16);
            this.label3lblExperiencePointsNotValue.TabIndex = 57;
            this.label3lblExperiencePointsNotValue.Text = "Experience points:";
            // 
            // ProfileScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpanishQuiz__coursework__Manus.Properties.Resources.SpanFlag2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.label3lblExperiencePointsNotValue);
            this.Controls.Add(this.lblXp);
            this.Controls.Add(this.lblMaxXp);
            this.Controls.Add(this.lblMinXp);
            this.Controls.Add(this.prgXp);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblHighscoreColon);
            this.Controls.Add(this.lblUsernameColon);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileScreen";
            this.Text = "Vale ~ Profile screen";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblUsernameColon;
        private System.Windows.Forms.Label lblHighscoreColon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizSelectScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsScreenTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.Label lblMaxXp;
        private System.Windows.Forms.Label lblMinXp;
        private System.Windows.Forms.ProgressBar prgXp;
        private System.Windows.Forms.Label label3lblExperiencePointsNotValue;
        private System.Windows.Forms.ToolStripMenuItem loginScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileScreenHelpToolStripMenuItem;
    }
}