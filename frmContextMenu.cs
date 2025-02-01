using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmContextMenu : Form
    {
        public frmContextMenu()
        {
            InitializeComponent();
        }

        private Font OriginalFont;
        private Color OriginalColor = Color.White;

        private void sadToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }

            else
                return;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OriginalColor = textBox1.BackColor;
            OriginalFont = textBox1.Font;

            fontDialog1.Font = textBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.BackColor = fontDialog1.Color;
            }

            else
            {
                textBox1.Font = OriginalFont;
                textBox1.BackColor = OriginalColor;
            }
        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.BackColor = fontDialog1.Color;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                treeView1.SelectedNode.Text = textBox1.Text;
            }
        }

        private void addNewParentNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                treeView1.Nodes.Add(textBox1.Text);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = OriginalFont;
            textBox1.BackColor = OriginalColor;
        }
    }
}
