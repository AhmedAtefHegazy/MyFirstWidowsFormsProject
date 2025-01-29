using System.Linq;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            tabControl1.SelectTab(1);
            return;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            tabControl1.SelectTab(2);
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("One");
                    comboBox2.Items.Add("Two");
                    comboBox2.Items.Add("Three");
                    comboBox2.Items.Add("Four");
                    comboBox2.Items.Add("Five");
                    comboBox2.Items.Add("Six");

                    break;
                case 1:
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("One");
                    comboBox2.Items.Add("Two");
                    comboBox2.Items.Add("Three");

                    break;
                case 2:
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("One");
                    comboBox2.Items.Add("Two");
                    comboBox2.Items.Add("Three");

                    break;

                default:
                    break;
            }
        }

        private void frmTabControl_Load(object sender, System.EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text.Length < 4
                ||

                (
                string.IsNullOrWhiteSpace(textBox2.Text)
                || ((!textBox2.Text.Any(char.IsUpper)
                && (!textBox2.Text.Any(char.IsLower)))
                )

                || textBox2.Text.Any(char.IsDigit)
                || textBox2.Text.Any(char.IsPunctuation)))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "This field is Required");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !textBox1.Text.Any(char.IsDigit) || textBox1.Text.Any(char.IsLetter) || textBox1.Text.Any(char.IsPunctuation))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "This field is Required");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)
                && !string.IsNullOrWhiteSpace(textBox2.Text)
                && !string.IsNullOrEmpty(comboBox1.Text)
                && !string.IsNullOrEmpty(comboBox2.Text)
               )
            {
                ListViewItem Item = new ListViewItem(textBox1.Text);

                Item.SubItems.Add(textBox2.Text);
                Item.SubItems.Add(comboBox1.Text);
                Item.SubItems.Add(comboBox2.Text);

                listView1.Items.Add(Item);

                MessageBox.Show("Student Added Successfuly");

                textBox1.Clear();
                textBox1.Focus();
                textBox2.Clear();
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }

            else
                return;
        }
    }
}
