using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmComboBoxExercise : Form
    {
        public frmComboBoxExercise()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (comboBox1.Text)
            //{
            //    case "Book":
            //        label1.Text = "Book";
            //        pictureBox1.Image = Resources.Book;

            //        break;

            //    case "Boy":
            //        label1.Text = "Boy";
            //        pictureBox1.Image = Resources.Boy;

            //        break;

            //    case "Girl":
            //        label1.Text = "Girl";
            //        pictureBox1.Image = Resources.Girl;

            //        break;

            //    case "Pen":
            //        label1.Text = "Pen";
            //        pictureBox1.Image = Resources.Pen;

            //        break;

            //    default:
            //        break;
            //}

            // OR

            string ActiveChoice = ((ComboBox)sender).Text;
            label1.Text = ActiveChoice;
            //pictureBox1.Image = Image.FromFile($"D:/Ahmed/s/programming learn/studying/Part 2 (C# & SQL)/Course 14/MyFirstWidowsFormsProject(PIZZA)/Resources/{ActiveChoice}.png");
            //OR
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(ActiveChoice);

        }

        private void frmComboBoxExercise_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
