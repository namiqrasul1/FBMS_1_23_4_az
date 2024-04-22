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

namespace Lesson8WpfCoding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string SomeText { get; set; } = "Hakuna";



        public string SomeDP
        {
            get { return (string)GetValue(SomeDPProperty); }
            set { SetValue(SomeDPProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SomeDP.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SomeDPProperty =
            DependencyProperty.Register("SomeDP", typeof(string), typeof(MainWindow));



        public MainWindow()
        {
            InitializeComponent();
            SomeDP = "John";
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SomeText = "Matata";
            SomeDP = "Matata";
        }
    }
}
