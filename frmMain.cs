//Tag is an atatched variable to controls 

using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnMessageBoxForm_Click(object sender, EventArgs e)
        {
            Form frmMessageBox = new frmMessageBox();
            frmMessageBox.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmChkRadioGroup = new frmChkRadioGroup();
            frmChkRadioGroup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmMoreAboutTxt();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Picturefrm = new frmPictureBox();
            Picturefrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new frmPBExercise();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new frmDrawing_In_C_();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaskedTextBox();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new frmComboBox();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new frmComboBoxExercise();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new frmLinkLabel();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm = new frmChkedListBox();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new frmDateTimePicker();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new frmMonthCalender();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimer();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm = new frmNotifyIcon();
            frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form frm = new frmTreeView_ImageList();
            frm.ShowDialog();
        }
    }
}
