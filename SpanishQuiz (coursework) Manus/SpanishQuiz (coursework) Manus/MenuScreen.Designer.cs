namespace SpanishQuiz__coursework__Manus
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(33, 134);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 50);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(33, 198);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(100, 50);
            this.btnLeaderboard.TabIndex = 1;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(33, 326);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 50);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.MediumBlue;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(33, 262);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(100, 50);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Location = new System.Drawing.Point(699, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(110, 110);
            this.picAvatar.TabIndex = 4;
            this.picAvatar.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::SpanishQuiz__coursework__Manus.Properties.Resources.red_and_blue_logo;
            this.picLogo.Location = new System.Drawing.Point(373, 159);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(339, 192);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
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
            this.menuStrip1.TabIndex = 6;
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsername.Location = new System.Drawing.Point(696, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 16);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "lblUsername";
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
            this.lblLevel.TabIndex = 47;
            this.lblLevel.Tag = "";
            this.lblLevel.Text = "1";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuScreen";
            this.Text = "Vale ~ Menu screen";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizSelectScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsScreenTutorialToolStripMenuItem;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ToolStripMenuItem loginScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileScreenHelpToolStripMenuItem;
    }
}