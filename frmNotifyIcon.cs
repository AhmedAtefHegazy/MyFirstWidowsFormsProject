using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            //notifyIcon1.BalloonTipTitle = "This is a Title";
            //notifyIcon1.BalloonTipText = "This is a message";
            notifyIcon1.ShowBalloonTip(1000, "This is a Title", "This is a message", ToolTipIcon.Error);


        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Ballon Tip Clicked");
            this.Close();

        }
    }
}
