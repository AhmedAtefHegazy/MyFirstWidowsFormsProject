using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmChkRadioGroup : Form
    {
        public frmChkRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(chkRecieveEmails.Checked.ToString());
        }

        private void chkRecieveEmails_CheckedChanged(object sender, System.EventArgs e)
        {
            button1.Enabled = chkRecieveEmails.Checked;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            button2.Enabled = radioButton1.Checked;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            gbBox1.Enabled = false;
        }
    }
}
