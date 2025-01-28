using System;
using System.Windows.Forms;

namespace ListViewProgram
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            if (rbMale.Checked)
                item.ImageIndex = 0;
            else item.ImageIndex = 1;

            item.SubItems.Add(txtName.Text.Trim());
            txtID.Clear();
            txtName.Clear();
            txtID.Focus();

            listView1.Items.Add(item);
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            //int SelectedItemsCount = listView1.SelectedItems.Count; // we implement it like this because it's changed when we press the button

                
            //for (int i = 0; i < listView1.SelectedItems.Count; i++)
            //    listView1.Items.Remove(listView1.SelectedItems[0]);

            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }

            // Show a message box if no item is selected
            else
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFillRandom_Click(object sender, System.EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                //ListViewItem item = new ListViewItem((i + 1).ToString());
                //item.ImageIndex = 0;
                //item.SubItems.Add("Person" + (i + 1));

                listView1.Items.Add((i + 1).ToString(), rnd.Next(2)).SubItems.Add($"Person {i + 1}");
            }

        }

        //One Event for all Radio Buttons

        //private void ChangeView(View view)
        //{
        //    listView1.View = view;
        //}

        //private void rbDetails_CheckedChanged(object sender, EventArgs e)
        //{
        //    ChangeView((View)Convert.ToByte(((RadioButton)sender).Tag));
        //}

        private void rbDetails_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLarge_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void rbSmall_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void rbList_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.View = View.List;

        }

        private void rbTile_CheckedChanged(object sender, System.EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void listView1_ItemActivate(object sender, System.EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }
    }
}
