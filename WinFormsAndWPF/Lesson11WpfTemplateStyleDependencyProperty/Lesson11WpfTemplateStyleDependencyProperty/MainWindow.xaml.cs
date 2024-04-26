using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Lesson11WpfTemplateStyleDependencyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //protected string? someText;
        //public string? SomeText
        //{
        //    get => someText;
        //    set
        //    {
        //        someText = value;
        //        OnPropertyChanged();
        //    }
        //}



        public string SomeText
        {
            get { return (string)GetValue(SomeTextProperty); }
            set { SetValue(SomeTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SomeText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SomeTextProperty =
            DependencyProperty.Register("SomeText", typeof(string), typeof(MainWindow));



        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SomeText = "Hakuna Matata";
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            var files = di.GetFiles().ToList();
        }
    }
}
