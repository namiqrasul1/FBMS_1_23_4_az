using Lesson9WpfResoucreBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Lesson9WpfResoucreBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //public string SomeText { get; set; } = "Hakuna Matata";
        private string? someText;

        public string? SomeText
        {
            get { return someText; }
            set
            {
                someText = value;
                OnPropertyChanged();
            }
        }

        private Car myCar;

        public Car MyCar
        {
            get { return myCar; }
            set
            {
                myCar = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Car> Cars { get; set; }

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        static int i = 1;
        public MainWindow()
        {
            InitializeComponent();
            SomeText = "Hakuna Matata";

            MyCar = new Car();

            Cars = new ObservableCollection<Car>
            {
                new Car { Vendor = "Nissan", Model = "Skyline", Year = 1999 },
                new Car { Vendor = "Toyota", Model = "Supra", Year = 1999 },
            };

            DataContext = this;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources["primaryColor"] = Brushes.DarkCyan;
            Resources["primaryHeight"] = 30.0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SomeText = $"John Doe {i++}";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyCar.Model = "GTR";
            MessageBox.Show($"{MyCar.Vendor} {MyCar.Model} {MyCar.Year}");
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            InfoCarWindow infoCar = new();
            infoCar.MyCar = (sender as ListView)?.SelectedItem as Car;
            Hide();
            infoCar.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            infoCar.ShowDialog();
            Show();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Cars.Add(MyCar);
            MyCar = new();
        }
    }
}
