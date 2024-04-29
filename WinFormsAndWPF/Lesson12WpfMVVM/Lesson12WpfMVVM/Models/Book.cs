using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12WpfMVVM.Models
{
    public class Book : INotifyPropertyChanged
    {
        private string name;
        private string author;
        private int publishYear;

        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public string Author { get => author; set { author = value; OnPropertyChanged(); } }
        public int PublishYear
        {
            get => publishYear; set { publishYear = value; OnPropertyChanged(); }
        }

        public Book Clone() => new Book { Name = Name, Author = Author, PublishYear = PublishYear };

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
