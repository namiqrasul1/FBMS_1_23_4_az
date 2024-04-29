using Lesson12WpfMVVM.Commands;
using Lesson12WpfMVVM.Models;
using Lesson12WpfMVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson12WpfMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Book book;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Book Book { get => book; set { book = value; OnPropertyChanged(); } }

        public RelayCommand EditCommand { get; set; }

        public MainViewModel()
        {
            Book = new Book
            {
                Author = "Dan Brown",
                Name = "Inferno",
                PublishYear = 2013
            };

            EditCommand = new RelayCommand(parameter =>
            {
                var editViewModel = new EditViewModel();
                editViewModel.Book = Book.Clone();
                var editView = new EditView();
                editViewModel.currentView = editView;
                editView.DataContext = editViewModel;
                if (editView.ShowDialog() == true)
                    Book = editViewModel.Book;
            });
        }

        private void Edit(object? parameter) { }
    }
}
