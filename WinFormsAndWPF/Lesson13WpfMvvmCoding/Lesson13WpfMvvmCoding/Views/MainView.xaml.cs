using Lesson13WpfMvvmCoding.ViewModels;
using System.Windows;

namespace Lesson13WpfMvvmCoding.Views;


public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
