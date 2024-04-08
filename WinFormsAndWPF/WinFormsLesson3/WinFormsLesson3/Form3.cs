using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            using InstalledFontCollection ifc = new();
            foreach (var fa in ifc.Families)
            {
                comboBox1.Items.Add(fa.Name);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Files|*.*|Text Files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void BtncColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
