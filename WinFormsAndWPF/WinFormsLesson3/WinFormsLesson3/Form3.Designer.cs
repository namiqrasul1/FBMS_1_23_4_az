namespace WinFormsLesson3
{
    partial class Form3
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
            saveFileDialog1 = new SaveFileDialog();
            btnSave = new Button();
            richTextBox1 = new RichTextBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            BtnFont = new Button();
            BtnOpenFile = new Button();
            BtncColor = new Button();
            BtnSelectFolder = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(582, 58);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(45, 58);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(400, 310);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnFont
            // 
            BtnFont.Location = new Point(582, 103);
            BtnFont.Margin = new Padding(4, 5, 4, 5);
            BtnFont.Name = "BtnFont";
            BtnFont.Size = new Size(118, 35);
            BtnFont.TabIndex = 0;
            BtnFont.Text = "Font";
            BtnFont.UseVisualStyleBackColor = true;
            BtnFont.Click += BtnFont_Click;
            // 
            // BtnOpenFile
            // 
            BtnOpenFile.Location = new Point(582, 148);
            BtnOpenFile.Margin = new Padding(4, 5, 4, 5);
            BtnOpenFile.Name = "BtnOpenFile";
            BtnOpenFile.Size = new Size(118, 35);
            BtnOpenFile.TabIndex = 0;
            BtnOpenFile.Text = "OpenFile";
            BtnOpenFile.UseVisualStyleBackColor = true;
            BtnOpenFile.Click += BtnOpenFile_Click;
            // 
            // BtncColor
            // 
            BtncColor.Location = new Point(582, 193);
            BtncColor.Margin = new Padding(4, 5, 4, 5);
            BtncColor.Name = "BtncColor";
            BtncColor.Size = new Size(118, 35);
            BtncColor.TabIndex = 0;
            BtncColor.Text = "Color";
            BtncColor.UseVisualStyleBackColor = true;
            BtncColor.Click += BtncColor_Click;
            // 
            // BtnSelectFolder
            // 
            BtnSelectFolder.AutoSize = true;
            BtnSelectFolder.Location = new Point(582, 238);
            BtnSelectFolder.Margin = new Padding(4, 5, 4, 5);
            BtnSelectFolder.Name = "BtnSelectFolder";
            BtnSelectFolder.Size = new Size(118, 35);
            BtnSelectFolder.TabIndex = 0;
            BtnSelectFolder.Text = "SelectFolder";
            BtnSelectFolder.UseVisualStyleBackColor = true;
            BtnSelectFolder.Click += BtnSelectFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(489, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 31);
            comboBox1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(BtnSelectFolder);
            Controls.Add(BtncColor);
            Controls.Add(BtnOpenFile);
            Controls.Add(BtnFont);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button btnSave;
        private RichTextBox richTextBox1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button BtnFont;
        private Button BtnOpenFile;
        private Button BtncColor;
        private Button BtnSelectFolder;
        private Label label1;
        private ComboBox comboBox1;
    }
}