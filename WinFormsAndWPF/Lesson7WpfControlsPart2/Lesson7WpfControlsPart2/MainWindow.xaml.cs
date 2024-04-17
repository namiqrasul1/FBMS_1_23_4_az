using Lesson7WpfControlsPart2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson7WpfControlsPart2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //BindingClass context;

        public string NameTxt { get; set; } = "Hakuna Matata";
        public SolidColorBrush BackColor { get; set; } = new(Colors.DarkMagenta);
        public int FontSize1 { get; set; } = 20;

        public DateTime Date { get; set; }

        public List<Book> Books { get; set; }

        public List<Person> People { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //context = new BindingClass();
            //DataContext = context;

            Books = new List<Book>()
            {
                new Book{Id = 1, Name = "Angels And Demons", Author = "Dan Brown", ImagePath = "https://m.media-amazon.com/images/I/711nh5VubdL._AC_UF1000,1000_QL80_.jpg" },
                new Book{Id = 2, Name = "The Devil's Star", Author = "Jo Nesbo", ImagePath = "https://m.media-amazon.com/images/I/71nJFyUn2mL._AC_UF894,1000_QL80_.jpg" },
                new Book{Id = 2, Name = "Arxali Canavar", Author = "Elxan Elatli", ImagePath = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1372002255i/18111860.jpg"},
            };

            People = new Bogus.Faker<Person>()
                    .RuleFor(p => p.Id, f => f.Random.Number(0, 100))
                    .RuleFor(p => p.Name, f => f.Person.FirstName)
                    .RuleFor(p => p.Surname, f => f.Person.LastName)
                    .RuleFor(p => p.Avatar, f => f.Person.Avatar)
                    .RuleFor(p => p.PhoneNumber, f => f.Person.Phone)
                    .RuleFor(p => p.Gender, f => f.Person.Gender.ToString())
                    .RuleFor(p => p.BDate, f => f.Person.DateOfBirth)
                    .RuleFor(p => p.Email, f => f.Person.Email)
                    .Generate(50);


            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //context.Foo();

            //MessageBox.Show(NameTxt);

            NameTxt = "John Doe";
        }
    }
}
