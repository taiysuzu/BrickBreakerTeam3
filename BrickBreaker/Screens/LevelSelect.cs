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
    }
}
