using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private int Seconds = 0;
        private int Minuts = 0;
        private int Hours = 0;
        private int Days = 0;
        string Time = "";
        string SecString = "";
        string MinString = "";
        string HoString = "";
        string DaString = "";


        private void timer1_Tick(object sender, EventArgs e)
        {
            Seconds++;

            if (Seconds == 60)
            {
                Minuts++;
                Seconds = 0;
            }

            if (Minuts == 60)
            {
                Hours++;
                Minuts = 0;
            }

            if (Hours == 24)
            {
                Days++;
                Hours = 0;
            }


            //*********************

            if (Seconds <= 9)
            {
                SecString = "0" + Seconds;
            }

            else
            {
                SecString = Seconds.ToString();
            }

            if (Minuts <= 9)
            {
                MinString = "0" + Minuts;
            }

            else
            {
                MinString = Minuts.ToString();
            }

            if (Hours <= 9)
            {
                HoString = "0" + Hours;
            }

            else
            {
                HoString = Hours.ToString();
            }

            if (Days <= 9)
            {
                DaString = "0" + Days;
            }

            else
            {
                DaString = Seconds.ToString();
            }

            Time = DaString + ":" + HoString + ":" + MinString + ":" + SecString;

            label1.Text = Time;

        }
    }
}
