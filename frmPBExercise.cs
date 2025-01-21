using System;
using System.Windows.Forms;
using MyFirstWidowsFormsProject_PIZZA_.Properties;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmPBExercise : Form
    {
        public frmPBExercise()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Image = Resources.Boy;
            label1.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            label1.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Image = Resources.Book;
            label1.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Image = Resources.Pen;
            label1.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void frmPBExercise_Load(object sender, EventArgs e)
        {
            label1.Text = "Boy";
        }
    }
}
