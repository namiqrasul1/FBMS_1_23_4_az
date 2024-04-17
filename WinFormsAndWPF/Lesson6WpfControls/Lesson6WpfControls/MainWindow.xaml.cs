using Lesson6WpfControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lesson6WpfControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Text { get; set; } = "Hakuna Matata";

        public ObservableCollection<Car> Cars { get; set; } = new()
        {
            new Car{ Vendor = "Nissan", Model ="Skyline R34", Year = 1999 },
            new Car{ Vendor = "Toyota", Model ="Supra Mk-4", Year = 1999 },
            new Car{ Vendor = "Ford", Model ="Mustang Shelby", Year = 1963 },
        };

        public MainWindow()
        {
            InitializeComponent();
            //CarList.ItemsSource = cars;
            //DataContext = new MainVM();
            DataContext = this;
        }

        //private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var car = CarList.SelectedItem as Car;
        //    if (car is not null)
        //    {
        //        LblVendor.Content = car.Vendor;
        //        LblModel.Content = car.Model;
        //        LblYear.Content = car.Year;
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var car = new Car { Vendor = "Tesla", Model = "Model X", Year = 2024 };
            //Cars.Add(car);
        }

        private void Button_Click_1_For_Expander(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                if(btn.Parent is StackPanel sp)
                {

                    //sp.Children.Clear();
                    if(sp.Parent is Expander ex)
                    {
                        ex.Header = "Changed";
                    }
                }
            }
        }


        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgBar.Value != prgBar.Maximum)
        //        prgBar.Value += 10;
        //    else
        //        prgBar.Value = prgBar.Minimum;
        //}

        //private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    Background = new SolidColorBrush(Color.FromRgb((byte)sldR.Value, (byte)sldG.Value, (byte)sldB.Value));
        //}
    }
}
