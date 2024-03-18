using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroApp
{
    internal partial class MainForm : Form
    {
        private int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            lbl1.Text = $"Clicked: {count}";
            count++;
            //MainForm form = new MainForm();
            //form.Show();
        }
    }
}
