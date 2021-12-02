using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker.Screens
{
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
        }

        private void HighscoreScreen_Load(object sender, EventArgs e)
        {
            //Form1.highscoreList.Sort();

            //if(Form1.highscoreList.Count > 5)
            //{
            //    Form1.highscoreList.RemoveAt(6);
            //}


            foreach(Scores s in Form1.highscoreList)
            {
                highscoreLabel.Text += $"{s.highscore}\n";
            }
        }
    }
}
