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

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        public static List <Scores> highscoreList = new List <Scores> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("resources/highscores.xml", null);

            writer.WriteStartElement("Highscores");

            foreach(Scores s in highscoreList)
            {
                writer.WriteStartElement("highscore");
                writer.WriteElementString("score", s.highscore);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();

        }
        public void LoadHS()
        {
            string highscore;

            XmlReader reader = XmlReader.Create("resources/highscores.xml");

            while(reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Text)
                {
                    highscore = reader.ReadString();

                    Scores newHScore = new Scores(highscore);
                    highscoreList.Add(newHScore);
                }
            }

            reader.Close();
        }
    }
}
