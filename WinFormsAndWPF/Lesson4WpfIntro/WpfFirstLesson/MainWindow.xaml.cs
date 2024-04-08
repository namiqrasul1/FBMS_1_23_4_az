using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfFirstLesson;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ClickMeBTN_ClickEvenet(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hakuna Matiti");
    }

    private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
    {

        //Button? btn = sender as Button;
        //btn!.Background = new SolidColorBrush(Color.FromRgb(15, 25, 155));
        //step.Background = new SolidColorBrush(Color.FromRgb(15, 25, 155));

        //((Grid)this.Content).Background= new SolidColorBrush(Color.FromRgb(15, 25, 155));

    }

    private void ChangeColorEvent(object sender, RoutedEventArgs e)
    {
        Button? btn = sender as Button;

        btn.Background = new SolidColorBrush(Color.FromRgb(1, 19, 61));
        btn.Foreground = new SolidColorBrush(Colors.White);


    }

    private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("sol");
    }

    private void ss(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            
            MessageBox.Show("asd");
        }
    }
}
