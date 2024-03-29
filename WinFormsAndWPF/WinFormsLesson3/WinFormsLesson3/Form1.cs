using System.Text.Json;
using WinFormsLesson3.Models;

namespace WinFormsLesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxLoad.Text))
            {
                LblValid.Visible = true; 
                return;
            }
            LblValid.Visible = false;
            try
            {
                string filePath = $"{TxtBoxLoad.Text}.json";
                var json = File.ReadAllText(filePath);
                var user = JsonSerializer.Deserialize<User>(json);
                TxtBoxFName.Text = user.FName;
                TxtBoxName.Text = user.Name;
                TxtBoxSurame.Text = user.Surname;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            /*
             <Button Height="100" Width="200"></Button>
             
             */
        }
    }
}