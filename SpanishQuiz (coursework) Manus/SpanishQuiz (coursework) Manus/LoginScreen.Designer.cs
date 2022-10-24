namespace SpanishQuiz__coursework__Manus
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.btnRegEnter = new System.Windows.Forms.Button();
            this.btnLogEnter = new System.Windows.Forms.Button();
            this.lblLogPassword = new System.Windows.Forms.Label();
            this.lblLogUsername = new System.Windows.Forms.Label();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.txtLogUsername = new System.Windows.Forms.TextBox();
            this.picAvatar1 = new System.Windows.Forms.PictureBox();
            this.picAvatar2 = new System.Windows.Forms.PictureBox();
            this.picAvatar3 = new System.Windows.Forms.PictureBox();
            this.lblRegAvatar = new System.Windows.Forms.Label();
            this.lblRegPasswordReq = new System.Windows.Forms.Label();
            this.lblRegPasswordReq1 = new System.Windows.Forms.Label();
            this.lblRegPasswordReq2 = new System.Windows.Forms.Label();
            this.lblAvatar1Selected = new System.Windows.Forms.Label();
            this.lblAvatar2Selected = new System.Windows.Forms.Label();
            this.lblAvatar3Selected = new System.Windows.Forms.Label();
            this.lblLogInvalidDetailsMessage = new System.Windows.Forms.Label();
            this.lblRegPasswordAgain = new System.Windows.Forms.Label();
            this.txtRegPasswordAgain = new System.Windows.Forms.TextBox();
            this.chkRegShowPassword = new System.Windows.Forms.CheckBox();
            this.chkLogShowPassword = new System.Windows.Forms.CheckBox();
            this.lblRegisterAccount = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
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
            this.lblRegInvalidDetails = new System.Windows.Forms.Label();
            this.btnCodeComplexities = new System.Windows.Forms.Button();
            this.btnQuizAnswers = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsername.Location = new System.Drawing.Point(40, 169);
            this.txtRegUsername.MaxLength = 12;
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(130, 26);
            this.txtRegUsername.TabIndex = 0;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(41, 223);
            this.txtRegPassword.MaxLength = 16;
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(130, 26);
            this.txtRegPassword.TabIndex = 2;
            this.txtRegPassword.TextChanged += new System.EventHandler(this.txtRegPassword_TextChanged);
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUsername.Location = new System.Drawing.Point(36, 146);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(83, 20);
            this.lblRegUsername.TabIndex = 3;
            this.lblRegUsername.Text = "Username";
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.Location = new System.Drawing.Point(36, 198);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(78, 20);
            this.lblRegPassword.TabIndex = 4;
            this.lblRegPassword.Text = "Password";
            // 
            // btnRegEnter
            // 
            this.btnRegEnter.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRegEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEnter.ForeColor = System.Drawing.Color.White;
            this.btnRegEnter.Location = new System.Drawing.Point(37, 335);
            this.btnRegEnter.Name = "btnRegEnter";
            this.btnRegEnter.Size = new System.Drawing.Size(100, 50);
            this.btnRegEnter.TabIndex = 5;
            this.btnRegEnter.Text = "Enter";
            this.btnRegEnter.UseVisualStyleBackColor = false;
            this.btnRegEnter.Click += new System.EventHandler(this.btnRegEnter_Click);
            // 
            // btnLogEnter
            // 
            this.btnLogEnter.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLogEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEnter.ForeColor = System.Drawing.Color.White;
            this.btnLogEnter.Location = new System.Drawing.Point(675, 335);
            this.btnLogEnter.Name = "btnLogEnter";
            this.btnLogEnter.Size = new System.Drawing.Size(100, 50);
            this.btnLogEnter.TabIndex = 11;
            this.btnLogEnter.Text = "Enter";
            this.btnLogEnter.UseVisualStyleBackColor = false;
            this.btnLogEnter.Click += new System.EventHandler(this.btnLogEnter_Click);
            // 
            // lblLogPassword
            // 
            this.lblLogPassword.AutoSize = true;
            this.lblLogPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblLogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogPassword.Location = new System.Drawing.Point(640, 198);
            this.lblLogPassword.Name = "lblLogPassword";
            this.lblLogPassword.Size = new System.Drawing.Size(78, 20);
            this.lblLogPassword.TabIndex = 10;
            this.lblLogPassword.Text = "Password";
            // 
            // lblLogUsername
            // 
            this.lblLogUsername.AutoSize = true;
            this.lblLogUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblLogUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogUsername.Location = new System.Drawing.Point(640, 146);
            this.lblLogUsername.Name = "lblLogUsername";
            this.lblLogUsername.Size = new System.Drawing.Size(83, 20);
            this.lblLogUsername.TabIndex = 9;
            this.lblLogUsername.Text = "Username";
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPassword.Location = new System.Drawing.Point(644, 223);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.PasswordChar = '*';
            this.txtLogPassword.Size = new System.Drawing.Size(130, 26);
            this.txtLogPassword.TabIndex = 8;
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUsername.Location = new System.Drawing.Point(644, 169);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.Size = new System.Drawing.Size(130, 26);
            this.txtLogUsername.TabIndex = 6;
            // 
            // picAvatar1
            // 
            this.picAvatar1.BackColor = System.Drawing.Color.White;
            this.picAvatar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAvatar1.BackgroundImage")));
            this.picAvatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar1.Location = new System.Drawing.Point(209, 255);
            this.picAvatar1.Name = "picAvatar1";
            this.picAvatar1.Size = new System.Drawing.Size(75, 75);
            this.picAvatar1.TabIndex = 12;
            this.picAvatar1.TabStop = false;
            this.picAvatar1.Click += new System.EventHandler(this.picAvatar1_Click);
            // 
            // picAvatar2
            // 
            this.picAvatar2.BackColor = System.Drawing.SystemColors.Control;
            this.picAvatar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAvatar2.BackgroundImage")));
            this.picAvatar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar2.Location = new System.Drawing.Point(290, 255);
            this.picAvatar2.Name = "picAvatar2";
            this.picAvatar2.Size = new System.Drawing.Size(75, 75);
            this.picAvatar2.TabIndex = 13;
            this.picAvatar2.TabStop = false;
            this.picAvatar2.Click += new System.EventHandler(this.picAvatar2_Click);
            // 
            // picAvatar3
            // 
            this.picAvatar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAvatar3.BackgroundImage")));
            this.picAvatar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar3.Location = new System.Drawing.Point(371, 255);
            this.picAvatar3.Name = "picAvatar3";
            this.picAvatar3.Size = new System.Drawing.Size(75, 75);
            this.picAvatar3.TabIndex = 14;
            this.picAvatar3.TabStop = false;
            this.picAvatar3.Click += new System.EventHandler(this.picAvatar3_Click);
            // 
            // lblRegAvatar
            // 
            this.lblRegAvatar.AutoSize = true;
            this.lblRegAvatar.BackColor = System.Drawing.Color.Transparent;
            this.lblRegAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegAvatar.Location = new System.Drawing.Point(206, 226);
            this.lblRegAvatar.Name = "lblRegAvatar";
            this.lblRegAvatar.Size = new System.Drawing.Size(55, 20);
            this.lblRegAvatar.TabIndex = 15;
            this.lblRegAvatar.Text = "Avatar";
            // 
            // lblRegPasswordReq
            // 
            this.lblRegPasswordReq.AutoSize = true;
            this.lblRegPasswordReq.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPasswordReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPasswordReq.Location = new System.Drawing.Point(206, 146);
            this.lblRegPasswordReq.Name = "lblRegPasswordReq";
            this.lblRegPasswordReq.Size = new System.Drawing.Size(175, 20);
            this.lblRegPasswordReq.TabIndex = 18;
            this.lblRegPasswordReq.Text = "Password requirements";
            // 
            // lblRegPasswordReq1
            // 
            this.lblRegPasswordReq1.AutoSize = true;
            this.lblRegPasswordReq1.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPasswordReq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPasswordReq1.ForeColor = System.Drawing.Color.Red;
            this.lblRegPasswordReq1.Location = new System.Drawing.Point(206, 166);
            this.lblRegPasswordReq1.Name = "lblRegPasswordReq1";
            this.lblRegPasswordReq1.Size = new System.Drawing.Size(276, 20);
            this.lblRegPasswordReq1.TabIndex = 19;
            this.lblRegPasswordReq1.Text = "Must be between 8 and 16 characters";
            // 
            // lblRegPasswordReq2
            // 
            this.lblRegPasswordReq2.AutoSize = true;
            this.lblRegPasswordReq2.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPasswordReq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPasswordReq2.ForeColor = System.Drawing.Color.Red;
            this.lblRegPasswordReq2.Location = new System.Drawing.Point(206, 184);
            this.lblRegPasswordReq2.Name = "lblRegPasswordReq2";
            this.lblRegPasswordReq2.Size = new System.Drawing.Size(245, 20);
            this.lblRegPasswordReq2.TabIndex = 20;
            this.lblRegPasswordReq2.Text = "Must contain at least one number";
            // 
            // lblAvatar1Selected
            // 
            this.lblAvatar1Selected.AutoSize = true;
            this.lblAvatar1Selected.BackColor = System.Drawing.Color.Transparent;
            this.lblAvatar1Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar1Selected.ForeColor = System.Drawing.Color.Green;
            this.lblAvatar1Selected.Location = new System.Drawing.Point(215, 333);
            this.lblAvatar1Selected.Name = "lblAvatar1Selected";
            this.lblAvatar1Selected.Size = new System.Drawing.Size(62, 16);
            this.lblAvatar1Selected.TabIndex = 22;
            this.lblAvatar1Selected.Text = "Selected";
            this.lblAvatar1Selected.Visible = false;
            // 
            // lblAvatar2Selected
            // 
            this.lblAvatar2Selected.AutoSize = true;
            this.lblAvatar2Selected.BackColor = System.Drawing.Color.Transparent;
            this.lblAvatar2Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar2Selected.ForeColor = System.Drawing.Color.Green;
            this.lblAvatar2Selected.Location = new System.Drawing.Point(298, 335);
            this.lblAvatar2Selected.Name = "lblAvatar2Selected";
            this.lblAvatar2Selected.Size = new System.Drawing.Size(62, 16);
            this.lblAvatar2Selected.TabIndex = 23;
            this.lblAvatar2Selected.Text = "Selected";
            this.lblAvatar2Selected.Visible = false;
            // 
            // lblAvatar3Selected
            // 
            this.lblAvatar3Selected.AutoSize = true;
            this.lblAvatar3Selected.BackColor = System.Drawing.Color.Transparent;
            this.lblAvatar3Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar3Selected.ForeColor = System.Drawing.Color.Green;
            this.lblAvatar3Selected.Location = new System.Drawing.Point(378, 333);
            this.lblAvatar3Selected.Name = "lblAvatar3Selected";
            this.lblAvatar3Selected.Size = new System.Drawing.Size(62, 16);
            this.lblAvatar3Selected.TabIndex = 24;
            this.lblAvatar3Selected.Text = "Selected";
            this.lblAvatar3Selected.Visible = false;
            // 
            // lblLogInvalidDetailsMessage
            // 
            this.lblLogInvalidDetailsMessage.AutoSize = true;
            this.lblLogInvalidDetailsMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLogInvalidDetailsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInvalidDetailsMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLogInvalidDetailsMessage.Location = new System.Drawing.Point(588, 365);
            this.lblLogInvalidDetailsMessage.Name = "lblLogInvalidDetailsMessage";
            this.lblLogInvalidDetailsMessage.Size = new System.Drawing.Size(81, 15);
            this.lblLogInvalidDetailsMessage.TabIndex = 25;
            this.lblLogInvalidDetailsMessage.Text = "Invalid details";
            this.lblLogInvalidDetailsMessage.Visible = false;
            // 
            // lblRegPasswordAgain
            // 
            this.lblRegPasswordAgain.AutoSize = true;
            this.lblRegPasswordAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPasswordAgain.Location = new System.Drawing.Point(37, 252);
            this.lblRegPasswordAgain.Name = "lblRegPasswordAgain";
            this.lblRegPasswordAgain.Size = new System.Drawing.Size(136, 20);
            this.lblRegPasswordAgain.TabIndex = 30;
            this.lblRegPasswordAgain.Text = "Confirm password";
            // 
            // txtRegPasswordAgain
            // 
            this.txtRegPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPasswordAgain.Location = new System.Drawing.Point(41, 275);
            this.txtRegPasswordAgain.MaxLength = 16;
            this.txtRegPasswordAgain.Name = "txtRegPasswordAgain";
            this.txtRegPasswordAgain.PasswordChar = '*';
            this.txtRegPasswordAgain.Size = new System.Drawing.Size(130, 26);
            this.txtRegPasswordAgain.TabIndex = 3;
            // 
            // chkRegShowPassword
            // 
            this.chkRegShowPassword.AutoSize = true;
            this.chkRegShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkRegShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegShowPassword.Location = new System.Drawing.Point(41, 305);
            this.chkRegShowPassword.Name = "chkRegShowPassword";
            this.chkRegShowPassword.Size = new System.Drawing.Size(122, 20);
            this.chkRegShowPassword.TabIndex = 31;
            this.chkRegShowPassword.TabStop = false;
            this.chkRegShowPassword.Text = "Show password";
            this.chkRegShowPassword.UseVisualStyleBackColor = false;
            this.chkRegShowPassword.CheckedChanged += new System.EventHandler(this.chkRegShowPassword_CheckedChanged);
            // 
            // chkLogShowPassword
            // 
            this.chkLogShowPassword.AutoSize = true;
            this.chkLogShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkLogShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogShowPassword.Location = new System.Drawing.Point(644, 255);
            this.chkLogShowPassword.Name = "chkLogShowPassword";
            this.chkLogShowPassword.Size = new System.Drawing.Size(122, 20);
            this.chkLogShowPassword.TabIndex = 32;
            this.chkLogShowPassword.TabStop = false;
            this.chkLogShowPassword.Text = "Show password";
            this.chkLogShowPassword.UseVisualStyleBackColor = false;
            this.chkLogShowPassword.CheckedChanged += new System.EventHandler(this.chkLogShowPassword_CheckedChanged);
            // 
            // lblRegisterAccount
            // 
            this.lblRegisterAccount.AutoSize = true;
            this.lblRegisterAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterAccount.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterAccount.Location = new System.Drawing.Point(33, 83);
            this.lblRegisterAccount.Name = "lblRegisterAccount";
            this.lblRegisterAccount.Size = new System.Drawing.Size(256, 37);
            this.lblRegisterAccount.TabIndex = 33;
            this.lblRegisterAccount.Text = "Register account";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.Black;
            this.lblLogIn.Location = new System.Drawing.Point(637, 83);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(105, 37);
            this.lblLogIn.TabIndex = 34;
            this.lblLogIn.Text = "Log in";
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
            this.menuStrip1.TabIndex = 35;
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
            // lblRegInvalidDetails
            // 
            this.lblRegInvalidDetails.AutoSize = true;
            this.lblRegInvalidDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblRegInvalidDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegInvalidDetails.ForeColor = System.Drawing.Color.Red;
            this.lblRegInvalidDetails.Location = new System.Drawing.Point(143, 365);
            this.lblRegInvalidDetails.Name = "lblRegInvalidDetails";
            this.lblRegInvalidDetails.Size = new System.Drawing.Size(0, 15);
            this.lblRegInvalidDetails.TabIndex = 36;
            // 
            // btnCodeComplexities
            // 
            this.btnCodeComplexities.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCodeComplexities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCodeComplexities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeComplexities.ForeColor = System.Drawing.Color.White;
            this.btnCodeComplexities.Location = new System.Drawing.Point(12, 453);
            this.btnCodeComplexities.Name = "btnCodeComplexities";
            this.btnCodeComplexities.Size = new System.Drawing.Size(120, 60);
            this.btnCodeComplexities.TabIndex = 37;
            this.btnCodeComplexities.Text = "Code complexities";
            this.btnCodeComplexities.UseVisualStyleBackColor = false;
            this.btnCodeComplexities.Click += new System.EventHandler(this.btnCodeComplexities_Click);
            // 
            // btnQuizAnswers
            // 
            this.btnQuizAnswers.BackColor = System.Drawing.Color.DarkViolet;
            this.btnQuizAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuizAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizAnswers.ForeColor = System.Drawing.Color.White;
            this.btnQuizAnswers.Location = new System.Drawing.Point(138, 453);
            this.btnQuizAnswers.Name = "btnQuizAnswers";
            this.btnQuizAnswers.Size = new System.Drawing.Size(120, 60);
            this.btnQuizAnswers.TabIndex = 38;
            this.btnQuizAnswers.Text = "Quiz answers";
            this.btnQuizAnswers.UseVisualStyleBackColor = false;
            this.btnQuizAnswers.Click += new System.EventHandler(this.btnQuizAnswers_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(264, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "*For examiners only*";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 525);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnQuizAnswers);
            this.Controls.Add(this.btnCodeComplexities);
            this.Controls.Add(this.lblRegInvalidDetails);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.lblRegisterAccount);
            this.Controls.Add(this.chkLogShowPassword);
            this.Controls.Add(this.chkRegShowPassword);
            this.Controls.Add(this.lblRegPasswordAgain);
            this.Controls.Add(this.txtRegPasswordAgain);
            this.Controls.Add(this.lblLogInvalidDetailsMessage);
            this.Controls.Add(this.lblAvatar3Selected);
            this.Controls.Add(this.lblAvatar2Selected);
            this.Controls.Add(this.lblAvatar1Selected);
            this.Controls.Add(this.lblRegPasswordReq2);
            this.Controls.Add(this.lblRegPasswordReq1);
            this.Controls.Add(this.lblRegPasswordReq);
            this.Controls.Add(this.lblRegAvatar);
            this.Controls.Add(this.picAvatar3);
            this.Controls.Add(this.picAvatar2);
            this.Controls.Add(this.picAvatar1);
            this.Controls.Add(this.btnLogEnter);
            this.Controls.Add(this.lblLogPassword);
            this.Controls.Add(this.lblLogUsername);
            this.Controls.Add(this.txtLogPassword);
            this.Controls.Add(this.txtLogUsername);
            this.Controls.Add(this.btnRegEnter);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.lblRegUsername);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.Text = "Vale ~ Login screen";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Button btnRegEnter;
        private System.Windows.Forms.Button btnLogEnter;
        private System.Windows.Forms.Label lblLogPassword;
        private System.Windows.Forms.Label lblLogUsername;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.TextBox txtLogUsername;
        private System.Windows.Forms.PictureBox picAvatar1;
        private System.Windows.Forms.PictureBox picAvatar2;
        private System.Windows.Forms.PictureBox picAvatar3;
        private System.Windows.Forms.Label lblRegAvatar;
        private System.Windows.Forms.Label lblRegPasswordReq;
        private System.Windows.Forms.Label lblRegPasswordReq1;
        private System.Windows.Forms.Label lblRegPasswordReq2;
        private System.Windows.Forms.Label lblAvatar1Selected;
        private System.Windows.Forms.Label lblAvatar2Selected;
        private System.Windows.Forms.Label lblAvatar3Selected;
        private System.Windows.Forms.Label lblLogInvalidDetailsMessage;
        private System.Windows.Forms.Label lblRegPasswordAgain;
        private System.Windows.Forms.TextBox txtRegPasswordAgain;
        private System.Windows.Forms.CheckBox chkRegShowPassword;
        private System.Windows.Forms.CheckBox chkLogShowPassword;
        private System.Windows.Forms.Label lblRegisterAccount;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizSelectScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsScreenTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.Label lblRegInvalidDetails;
        private System.Windows.Forms.ToolStripMenuItem loginScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardScreenHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileScreenHelpToolStripMenuItem;
        private System.Windows.Forms.Button btnCodeComplexities;
        private System.Windows.Forms.Button btnQuizAnswers;
        private System.Windows.Forms.Label label9;
    }
}