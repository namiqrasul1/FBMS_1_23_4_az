using MyFirstAmazingDesktopApp.Models;
using System.Text.Json;

namespace MyFirstAmazingDesktopApp
{
    public partial class Form1 : Form
    {
        //private static List<User> users = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_MouseClick(object sender, MouseEventArgs e)
        {
            //User user = new()
            //{
            //    Surname = TxtBoxSurname.Text,
            //    Name = TxtBoxName.Text,
            //    Age = int.Parse(TxtBoxAge.Text)
            //};

            //var json = JsonSerializer.Serialize(user);
            //File.WriteAllText("user.json", json);
            //MessageBox.Show("Data saved");

            //DateTimeOffset offset = DateTimeOffset.Now;
            //MessageBox.Show(offset.ToString());
        }
    }
}