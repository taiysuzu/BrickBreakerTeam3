using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the level select screen
            
            LevelSelect ls = new LevelSelect();
            Form form = this.FindForm();

            form.Controls.Add(ls);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }

        private void highscoresButton_Click(object sender, EventArgs e)
        {
            BrickBreaker.Screens.HighscoreScreen hs = new BrickBreaker.Screens.HighscoreScreen();
            Form form = this.FindForm();

            form.Controls.Add(hs);
            form.Controls.Remove(this);

            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            HowtoPlayScreen htps = new HowtoPlayScreen();
            Form form = this.FindForm();

            form.Controls.Add(htps);
            form.Controls.Remove(this);

            htps.Location = new Point((form.Width - htps.Width) / 2, (form.Height - htps.Height) / 2);
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            playButton.ForeColor = Color.Lime;     
        }
        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.ForeColor = Color.White;
        }
        private void instructionsButton_MouseEnter(object sender, EventArgs e)
        {
            instructionsButton.ForeColor = Color.Yellow;
        }
        private void instructionsButton_MouseLeave(object sender, EventArgs e)
        {
            instructionsButton.ForeColor = Color.White;
        }
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.Red;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.White;
        }
        private void highscoresButton_MouseLeave(object sender, EventArgs e)
        {
            highscoresButton.ForeColor = Color.White;
        }

        private void highscoresButton_MouseEnter(object sender, EventArgs e)
        {
            highscoresButton.ForeColor = Color.Blue;
        }
    }
}
