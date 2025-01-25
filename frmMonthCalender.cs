using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmMonthCalender : Form
    {
        public frmMonthCalender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToString("dd/MM/yyyy"));
        }
    }
}
