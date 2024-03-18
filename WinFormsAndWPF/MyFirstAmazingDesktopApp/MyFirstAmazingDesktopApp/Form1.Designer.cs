namespace MyFirstAmazingDesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblName = new Label();
            TxtBoxName = new TextBox();
            LblSurname = new Label();
            TxtBoxSurname = new TextBox();
            LblAge = new Label();
            TxtBoxAge = new TextBox();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(19, 15);
            LblName.Margin = new Padding(5, 0, 5, 0);
            LblName.Name = "LblName";
            LblName.Size = new Size(71, 25);
            LblName.TabIndex = 0;
            LblName.Text = "Name: ";
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new Point(125, 15);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.PlaceholderText = "Name";
            TxtBoxName.ScrollBars = ScrollBars.Horizontal;
            TxtBoxName.Size = new Size(307, 32);
            TxtBoxName.TabIndex = 0;
            // 
            // LblSurname
            // 
            LblSurname.AutoSize = true;
            LblSurname.Location = new Point(19, 53);
            LblSurname.Margin = new Padding(5, 0, 5, 0);
            LblSurname.Name = "LblSurname";
            LblSurname.Size = new Size(91, 25);
            LblSurname.TabIndex = 0;
            LblSurname.Text = "Surname:";
            // 
            // TxtBoxSurname
            // 
            TxtBoxSurname.Location = new Point(125, 53);
            TxtBoxSurname.Name = "TxtBoxSurname";
            TxtBoxSurname.PlaceholderText = "Surname";
            TxtBoxSurname.ScrollBars = ScrollBars.Horizontal;
            TxtBoxSurname.Size = new Size(307, 32);
            TxtBoxSurname.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(19, 91);
            LblAge.Margin = new Padding(5, 0, 5, 0);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(49, 25);
            LblAge.TabIndex = 0;
            LblAge.Text = "Age:";
            // 
            // TxtBoxAge
            // 
            TxtBoxAge.Location = new Point(125, 91);
            TxtBoxAge.Name = "TxtBoxAge";
            TxtBoxAge.PlaceholderText = "Age";
            TxtBoxAge.ScrollBars = ScrollBars.Horizontal;
            TxtBoxAge.Size = new Size(307, 32);
            TxtBoxAge.TabIndex = 2;
            // 
            // BtnSave
            // 
            BtnSave.AutoSize = true;
            BtnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSave.Location = new Point(371, 155);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(61, 35);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.MouseClick += BtnSave_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 244);
            Controls.Add(BtnSave);
            Controls.Add(TxtBoxAge);
            Controls.Add(LblAge);
            Controls.Add(TxtBoxSurname);
            Controls.Add(LblSurname);
            Controls.Add(TxtBoxName);
            Controls.Add(LblName);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtBoxName;
        private Label LblSurname;
        private TextBox TxtBoxSurname;
        private Label LblAge;
        private TextBox TxtBoxAge;
        private Button BtnSave;
    }
}