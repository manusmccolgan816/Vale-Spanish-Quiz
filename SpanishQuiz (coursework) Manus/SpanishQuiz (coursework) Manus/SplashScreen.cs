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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.CenterToScreen();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgLoadProgram.Increment(2);

            if(prgLoadProgram.Value == prgLoadProgram.Maximum)
            {
                Form Form1 = new LoginScreen();
                Form1.Show();
                timer1.Stop();
                this.Hide();
            }
        }
    }
}