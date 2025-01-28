using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (((textBox1.Text.TrimEnd()).Contains(" "))
                || !textBox1.Text.Contains("@gmail.com")
                && !textBox1.Text.Contains("@hotmail.com")
                && !textBox1.Text.Contains("@hotmail.com")
                && !textBox1.Text.Contains("@yahoo.com")
                && !textBox1.Text.Contains("@outlook.com")
                || (textBox1.Text.Length < 13))
            {
                e.Cancel = true;

                errorProvider1.SetError(textBox1, "Invalid Email Format");
            }

            else
            {
                e.Cancel = false;

                errorProvider1.SetError(textBox1, "");

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length < 12)
            {

                e.Cancel = true;

                errorProvider1.SetError(textBox2, "Password Length Must Be 12 For Minimum");

                if (!textBox2.Text.Any(char.IsUpper) || !textBox2.Text.Any(char.IsLower) || !textBox2.Text.Any(char.IsPunctuation))
                {
                    e.Cancel = true;

                    errorProvider1.SetError(textBox2, "Password Should Contains lower upper characters and specail characters like -/= etc");
                }

            }

            else
            {
                e.Cancel = false;

                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                e.Cancel = true;

                errorProvider1.SetError(textBox3, "Passwords Not Match !");
            }

            else
            {
                e.Cancel = false;

                errorProvider1.SetError(textBox3, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(textBox1.Text)) || (string.IsNullOrWhiteSpace(textBox1.Text)) || (string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';

                textBox2.Focus();
            }

            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
                textBox2.Focus();

            }
        }
    }
}
