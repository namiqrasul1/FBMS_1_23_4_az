using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroApp
{
    internal partial class MainForm
    {
        Button btn1;
        Label lbl1;
        private void InitializeComponent()
        {
            btn1 = new Button();
            lbl1 = new Label();

            btn1.AutoSize = true;
            btn1.Text = "Click me!";
            btn1.Location = new System.Drawing.Point(50, 50);
            btn1.Click += Btn1_Click;

            lbl1.AutoSize = true;
            lbl1.Text = "You haven't clicked yet!";



            Size = new System.Drawing.Size(500, 500);

            base.Controls.Add(btn1);
            base.Controls.Add(lbl1);
        }


    }
}
