namespace WinFormsLesson3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            trackBar1 = new TrackBar();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            monthCalendar1 = new MonthCalendar();
            maskedTextBox1 = new MaskedTextBox();
            hScrollBar1 = new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(373, 349);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.No;
            progressBar1.Size = new Size(254, 38);
            progressBar1.TabIndex = 0;
            toolTip1.SetToolTip(progressBar1, "Downloading...");
            progressBar1.Value = 50;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(322, 144);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 283);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(438, 137);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(36, 120);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(438, 49);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // hScrollBar1
            // 
            hScrollBar1.Dock = DockStyle.Bottom;
            hScrollBar1.Location = new Point(0, 433);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(800, 17);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hScrollBar1);
            Controls.Add(maskedTextBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ToolTip toolTip1;
        private TrackBar trackBar1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private MonthCalendar monthCalendar1;
        private MaskedTextBox maskedTextBox1;
        private HScrollBar hScrollBar1;
    }
}