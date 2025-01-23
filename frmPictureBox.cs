using System;
using System.Drawing;
using System.Windows.Forms;
using MyFirstWidowsFormsProject_PIZZA_.Properties;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbStrongWeak.Image = Image.FromFile("D:/Ahmed/s/programming learn/studying/Part 2 (C# & SQL)/Course 14/MyFirstWidowsFormsProject(PIZZA)/Weak.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pbStrongWeak.Image = Resources.Strong;
        }
    }
}
