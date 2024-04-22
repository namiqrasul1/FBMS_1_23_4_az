using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9WpfResoucreBinding.Models
{
    public class Car : INotifyPropertyChanged
    {
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; OnPropertyChanged(); }
        }

        private string vendor;

        public string Vendor
        {
            get { return vendor; }
            set { vendor = value; OnPropertyChanged(); }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
