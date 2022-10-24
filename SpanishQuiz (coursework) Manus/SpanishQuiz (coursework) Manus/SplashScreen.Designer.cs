namespace SpanishQuiz__coursework__Manus
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.prgLoadProgram = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // prgLoadProgram
            // 
            this.prgLoadProgram.Location = new System.Drawing.Point(225, 324);
            this.prgLoadProgram.Name = "prgLoadProgram";
            this.prgLoadProgram.Size = new System.Drawing.Size(368, 35);
            this.prgLoadProgram.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::SpanishQuiz__coursework__Manus.Properties.Resources.red_and_blue_logo;
            this.picLogo.Location = new System.Drawing.Point(225, 165);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(368, 153);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpanishQuiz__coursework__Manus.Properties.Resources.SpanFlag2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 525);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.prgLoadProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SplashScreen";
            this.Text = "Vale ~ Loading screen";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar prgLoadProgram;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}