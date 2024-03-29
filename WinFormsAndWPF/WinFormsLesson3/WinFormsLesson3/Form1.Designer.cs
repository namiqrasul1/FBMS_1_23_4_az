namespace WinFormsLesson3
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
            TxtBoxLoad = new TextBox();
            BtnLoad = new Button();
            TxtBoxName = new TextBox();
            TxtBoxSurame = new TextBox();
            TxtBoxFName = new TextBox();
            LblValid = new Label();
            SuspendLayout();
            // 
            // TxtBoxLoad
            // 
            TxtBoxLoad.Location = new Point(224, 18);
            TxtBoxLoad.Margin = new Padding(4, 5, 4, 5);
            TxtBoxLoad.Name = "TxtBoxLoad";
            TxtBoxLoad.Size = new Size(206, 31);
            TxtBoxLoad.TabIndex = 0;
            // 
            // BtnLoad
            // 
            BtnLoad.AutoSize = true;
            BtnLoad.Location = new Point(437, 14);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(86, 35);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Load";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // TxtBoxName
            // 
            TxtBoxName.Location = new Point(36, 85);
            TxtBoxName.Margin = new Padding(4, 5, 4, 5);
            TxtBoxName.Name = "TxtBoxName";
            TxtBoxName.Size = new Size(206, 31);
            TxtBoxName.TabIndex = 0;
            // 
            // TxtBoxSurame
            // 
            TxtBoxSurame.Location = new Point(36, 126);
            TxtBoxSurame.Margin = new Padding(4, 5, 4, 5);
            TxtBoxSurame.Name = "TxtBoxSurame";
            TxtBoxSurame.Size = new Size(206, 31);
            TxtBoxSurame.TabIndex = 0;
            // 
            // TxtBoxFName
            // 
            TxtBoxFName.Location = new Point(36, 167);
            TxtBoxFName.Margin = new Padding(4, 5, 4, 5);
            TxtBoxFName.Name = "TxtBoxFName";
            TxtBoxFName.Size = new Size(206, 31);
            TxtBoxFName.TabIndex = 0;
            // 
            // LblValid
            // 
            LblValid.AutoSize = true;
            LblValid.ForeColor = Color.Red;
            LblValid.Location = new Point(131, 21);
            LblValid.Name = "LblValid";
            LblValid.Size = new Size(82, 25);
            LblValid.TabIndex = 2;
            LblValid.Text = "Required";
            LblValid.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(LblValid);
            Controls.Add(BtnLoad);
            Controls.Add(TxtBoxFName);
            Controls.Add(TxtBoxSurame);
            Controls.Add(TxtBoxName);
            Controls.Add(TxtBoxLoad);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBoxLoad;
        private Button BtnLoad;
        private TextBox TxtBoxName;
        private TextBox TxtBoxSurame;
        private TextBox TxtBoxFName;
        private Label LblValid;
    }
}