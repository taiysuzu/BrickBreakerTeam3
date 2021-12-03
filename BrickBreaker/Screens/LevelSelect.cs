using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class LevelSelect : UserControl
    {
        public static int counter = 1;
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void leftButton_MouseEnter(object sender, EventArgs e)
        {
            leftButton.ForeColor = Color.Red;
        }

        private void rightButton_MouseEnter(object sender, EventArgs e)
        {
            rightButton.ForeColor = Color.Red;
        }

        private void rightButton_MouseLeave(object sender, EventArgs e)
        {
            rightButton.ForeColor = Color.Black;
        }

        private void leftButton_MouseLeave(object sender, EventArgs e)
        {
            leftButton.ForeColor = Color.Black;
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            leftButton.Visible = true;
            counter++;
            if (counter == 2)
            {
                difficultyLabel.Text = "Difficulty: Normal";
                difficultyLabel.ForeColor = Color.Goldenrod;
                this.BackgroundImage = Properties.Resources.dababyBackground;
            }
            if (counter == 3)
            {
                difficultyLabel.Text = "Difficulty: Hard";
                difficultyLabel.ForeColor = Color.Red;
                this.BackgroundImage = Properties.Resources.LebronBackground;
                rightButton.Visible = false;
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            rightButton.Visible = true;
            counter--;
            if (counter == 2)
            {
                difficultyLabel.Text = "Difficulty: Normal";
                difficultyLabel.ForeColor = Color.Goldenrod;
                this.BackgroundImage = Properties.Resources.dababyBackground;
            }
            if (counter == 1)
            {
                difficultyLabel.Text = "Difficulty: Easy";
                difficultyLabel.ForeColor = Color.Lime;
                this.BackgroundImage = Properties.Resources.MarioBackground;
                leftButton.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }
    }
}
