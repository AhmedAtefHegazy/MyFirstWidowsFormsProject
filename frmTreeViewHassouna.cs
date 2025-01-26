using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmTreeViewHassouna : Form
    {
        public frmTreeViewHassouna()
        {
            InitializeComponent();
        }

        private void tvOpenForms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = new Form();

            string strform = tvOpenForms.SelectedNode.Text.ToLower();

            if (strform == "home") frm = new frmHome();
            else if (strform == "person") frm = new frmPerson();
            else if (strform == "tables") frm = new Tables();
            else if (strform == "cash") frm = new Cash();
            else if (strform == "notes") frm = new Notes();
            else Application.Exit();

            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == frm.Text)
                {
                    item.Activate();
                    return;
                }
            }


            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();


        }
    }
}
