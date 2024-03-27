namespace WinFormsLesson2Controls
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
            listBox1 = new ListBox();
            TxtBxName = new TextBox();
            TxtBxSur = new TextBox();
            BtnAdd = new Button();
            listBox2 = new ListBox();
            button1 = new Button();
            GenderBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(16, 18);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(326, 257);
            listBox1.TabIndex = 0;
            // 
            // TxtBxName
            // 
            TxtBxName.Location = new Point(16, 292);
            TxtBxName.Name = "TxtBxName";
            TxtBxName.PlaceholderText = "Name";
            TxtBxName.Size = new Size(326, 31);
            TxtBxName.TabIndex = 1;
            // 
            // TxtBxSur
            // 
            TxtBxSur.Location = new Point(16, 329);
            TxtBxSur.Name = "TxtBxSur";
            TxtBxSur.PlaceholderText = "Surname";
            TxtBxSur.Size = new Size(326, 31);
            TxtBxSur.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.AutoSize = true;
            BtnAdd.Location = new Point(256, 403);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(86, 35);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(650, 18);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(340, 257);
            listBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.right;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(467, 93);
            button1.Name = "button1";
            button1.Size = new Size(78, 58);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GenderBox
            // 
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderBox.Location = new Point(16, 379);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(182, 31);
            GenderBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(699, 379);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 690);
            Controls.Add(dateTimePicker1);
            Controls.Add(GenderBox);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(BtnAdd);
            Controls.Add(TxtBxSur);
            Controls.Add(TxtBxName);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox TxtBxName;
        private TextBox TxtBxSur;
        private Button BtnAdd;
        private ListBox listBox2;
        private Button button1;
        private ComboBox GenderBox;
        private DateTimePicker dateTimePicker1;
    }
}