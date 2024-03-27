using System.Text.RegularExpressions;

namespace WinFormsLesson2Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;

            //groupBox1.Controls.Add(checkBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Select(2, 7);
            ////richTextBox1.DeselectAll();
            //richTextBox1.Cut();
            //richTextBox1.Copy();
            //textBox1.Paste();

            richTextBox1.WordWrap = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-zA-Z ]{3,15}$");
            if (regex.IsMatch(textBox1.Text))
                textBox1.ForeColor = Color.Green;
            else textBox1.ForeColor = Color.Red;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
                if (rb.Checked)
                    MessageBox.Show(rb.Text);
        }
    }
}