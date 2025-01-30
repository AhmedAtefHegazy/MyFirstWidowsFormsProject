using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmDialogs : Form
    {
        public frmDialogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private Font OriginalFont;
        private Color OriginalColor;

        private void button3_Click(object sender, EventArgs e)
        {
            OriginalColor = textBox1.ForeColor;
            OriginalFont = textBox1.Font;

            fontDialog1.Font = textBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
            else
            {
                textBox1.Font = OriginalFont;
                textBox1.ForeColor = OriginalColor;
            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    //saveFileDialog1.InitialDirectory = Application.StartupPath;
        //    saveFileDialog1.InitialDirectory = @"C:\";

        //    saveFileDialog1.Title = "this is dialog title";

        //    saveFileDialog1.DefaultExt = "txt";

        //    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";

        //    saveFileDialog1.FilterIndex = 2;

        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        MessageBox.Show(saveFileDialog1.FileName);
        //    }
        //}

        string GetFileName()
        {
            string[] FileDir = saveFileDialog1.FileName.Split('\\');
            return FileDir[FileDir.Length - 1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // next time he open the dialog the directory will be the same as last time
                saveFileDialog1.InitialDirectory = saveFileDialog1.FileName;

                StreamWriter File = new StreamWriter(saveFileDialog1.FileName);
                File.Write(textBox1.Text);
                File.Close();

                // to get file name without full directory
                saveFileDialog1.FileName = GetFileName();
                MessageBox.Show(saveFileDialog1.FileName + " Saved Successfully", "Saved Successfully");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "txt files|*.txt|all files|*.*";
            openFileDialog1.FilterIndex = 2;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader File = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = File.ReadLine();
                File.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
