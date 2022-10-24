namespace SpanishQuiz__coursework__Manus
{
    partial class LeaderboardScreen
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
            this.highscoreLeaderboard = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizSelectScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsScreenTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areYouSureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.loginScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileScreenHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // highscoreLeaderboard
            // 
            this.highscoreLeaderboard.BackColor = System.Drawing.Color.Yellow;
            this.highscoreLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highscoreLeaderboard.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLeaderboard.FormattingEnabled = true;
            this.highscoreLeaderboard.ItemHeight = 37;
            this.highscoreLeaderboard.Location = new System.Drawing.Point(18, 144);
            this.highscoreLeaderboard.Name = "highscoreLeaderboard";
            this.highscoreLeaderboard.Size = new System.Drawing.Size(502, 222);
            this.highscoreLeaderboard.TabIndex = 0;
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
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.menuStrip1.TabIndex = 44;
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsername.Location = new System.Drawing.Point(696, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 16);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "lblUsername";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Location = new System.Drawing.Point(699, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(110, 110);
            this.picAvatar.TabIndex = 45;
            this.picAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 42);
            this.label1.TabIndex = 47;
            this.label1.Text = "Highscore leaderboard";
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
            // LeaderboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpanishQuiz__coursework__Manus.Properties.Resources.SpanFlag2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.highscoreLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LeaderboardScreen";
            this.Text = "Vale ~ Leaderboard screen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox highscoreLeaderboard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizSelectScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsScreenTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ToolStripMenuItem loginScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileScreenHelpToolStripMenuItem;
    }
}