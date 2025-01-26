using System;
using System.Threading;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            button1.Cursor = Cursors.WaitCursor;
            button2.Cursor = Cursors.WaitCursor;
            progressBar1.Cursor = Cursors.WaitCursor;

            for (int i = 0; i < 100; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    label1.Refresh();

                    progressBar1.Value += 10;
                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100 + "%");
                }
                else
                    button1.Enabled = false;

            }

            button1.Cursor = Cursors.Default;
            button2.Cursor = Cursors.Default;
            progressBar1.Cursor = Cursors.Default;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            button1.Enabled = true;
            label1.Text = "0%";
        }
    }
}
