using System.Drawing;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmDrawing_In_C_ : Form
    {
        public frmDrawing_In_C_()
        {
            InitializeComponent();
        }

        private void frmDrawing_In_C__Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);
            Pen pen = new Pen(Black, 10);

            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 100, 100, 100, 200);
            e.Graphics.DrawLine(pen, 350, 350, 351, 351);
            e.Graphics.DrawRectangle(pen, 200, 200, 300, 300);
            e.Graphics.DrawEllipse(pen, 200, 200, 300, 300);
        }
    }
}
