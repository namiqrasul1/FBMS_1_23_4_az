using Lesson12WpfCommandsMvvm.Commands;
using System.ComponentModel.Design;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson12WpfCommandsMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public string SomeText { get; set; } = string.Empty;
        ////public MessageCommand MessageCommand { get; set; }

        //public RelayCommand MessageCommand { get; set; }
        //public RelayCommand SendCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //MessageCommand = new MessageCommand();

            //MessageCommand = new RelayCommand(MessageFunction);
            //SendCommand = new RelayCommand(Send, CanSend);

            DataContext = new BusinnessLogic();
        }

        //public void MessageFunction(object? parameter)
        //{
        //    MessageBox.Show(SomeText);
        //}

        //public void Send(object? parameter) => MessageBox.Show(SomeText);
        //public bool CanSend(object? parameter)
        //{
        //    return SomeText.Length > 10;
        //}
    }
}