using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLesson2Controls.Models;

namespace WinFormsLesson2Controls
{
    public partial class Form2 : Form
    {
        List<User> users = new()
        {
            new User(){ Name = "Hakuna", Surname = "Matata", Gender = "Male" },
            new User(){ Name = "John", Surname = "Doe", Gender = "Male" },
            new User(){ Name = "Mireli", Surname = "Ireli", Gender = "Male" },
        };

        private User _user = new();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            //listBox1.DataSource = users;
            listBox1.HorizontalScrollbar = true;
            listBox1.Items.AddRange(users.ToArray());

            //dateTimePicker1.Value = DateTime.Now.AddDays(2);

            //users.Add(new User { Name = "Kamil", Surname = "Nazim" });
            ////listBox1.Items.Add(users.Last());
            //listBox1.DataSource = null;
            //listBox1.DataSource = users;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new User
            {
                Name = TxtBxName.Text,
                Surname = TxtBxSur.Text,
                Gender = GenderBox.SelectedItem.ToString()!
            });
            TxtBxName.Text = string.Empty;
            TxtBxSur.Text = string.Empty;
            //listBox1.DataSource = null;
            //listBox1.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }

            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items[0]);
            }
        }
    }
}
