using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmChkedListBox : Form
    {
        public frmChkedListBox()
        {
            InitializeComponent();
        }

        short i = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            checkedListBox1.Items.Add("Item" + (++i));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[j].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < checkedListBox1.Items.Count; j++)
            {
                checkedListBox1.SetItemChecked(j, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < checkedListBox1.Items.Count; j++)
            {
                checkedListBox1.SetItemChecked(j, false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            short k = 2;

            if (checkedListBox1.Items.Count > k)
            {
                checkedListBox1.Items.RemoveAt(2);
            }
        }
            
        private void button6_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex >= 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }
    }
}
