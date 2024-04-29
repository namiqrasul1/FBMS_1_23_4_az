using Lesson12WpfCommandsMvvm.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson12WpfCommandsMvvm
{
    public class BusinnessLogic
    {
        public string SomeText { get; set; } = string.Empty;
        public RelayCommand SendCommand { get; set; }

        public BusinnessLogic()
        {
            SendCommand = new RelayCommand(Send, CanSend);
        }

        public void Send(object? parameter) => MessageBox.Show(SomeText);
        public bool CanSend(object? parameter)
        {
            return SomeText.Length > 10;
        }

    }
}
