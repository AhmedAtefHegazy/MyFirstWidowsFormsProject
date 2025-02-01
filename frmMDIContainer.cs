using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmMDIContainer : Form
    {
        public frmMDIContainer()
        {
            InitializeComponent();
        }

        private Form frm = new frmMDI_Child();


        //this func validate mdi valid or not 
        private void OpenChildForm(Form ChildForm)
        {
            if (ChildForm.IsMdiContainer)
            {
                MessageBox.Show("the form cannot be an mdi parent and child simultaneiusly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.IsMdiContainer)
            {
                MessageBox.Show("No Valid MDI Container found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frm.MdiParent = this;

            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm.IsDisposed)
                frm = new frmMDI_Child();

            OpenChildForm(frm);
        }
    }
}
