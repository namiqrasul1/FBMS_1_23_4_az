using MyFirstAmazingDesktopApp.Models;
using System.Text.Json;

namespace MyFirstAmazingDesktopApp
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new();
        //private static List<User> users = new();
        public Form1()
        {
            InitializeComponent();
            //Text = "Hakuna Matata";
            //Font = new Font("Comic Sans Ms", 50, FontStyle.Bold | FontStyle.Underline);
            ////System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
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

            //MessageBox.Show("Test");
            //MessageBox.Show("Hakuna", "Kamil");

            //MessageBox.Show("Test","caption", MessageBoxButtons.AbortRetryIgnore);
            //MessageBox.Show("Test","caption", MessageBoxButtons.CancelTryContinue);
            DialogResult dr = MessageBox.Show("Her shey duzdur?", "Cavab ver!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                User user = new()
                {
                    Surname = TxtBoxSurname.Text,
                    Name = TxtBoxName.Text,
                    Age = int.Parse(TxtBoxAge.Text)
                };

                var json = JsonSerializer.Serialize(user);
                File.WriteAllText("user.json", json);

                MessageBox.Show("Data saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dr == DialogResult.No) { }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            if (e.Button == MouseButtons.Left)
                BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            else if (e.Button == MouseButtons.Right)
                BackColor = Color.HotPink;
        }
    }
}