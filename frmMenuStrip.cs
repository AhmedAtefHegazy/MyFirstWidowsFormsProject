using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find Client is here. ");
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Client is here. ");

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Client is here. ");

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Client is here. ");

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login is here. ");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("option 1 is here. ");
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("option 1 is here. ");

        }
    }
}
