using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lesson15WpfCoding.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public RelayCommand AddCommand { get; set; }
        public RelayCommand AllProductsCommand { get; set; }
        public AppDbContext DbContext { get; set; }

        private Page currentPage;
        public Page CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value;  OnPropertyChanged(); }
        }

        public MainViewModel(AppDbContext dbContext)
        {
            AddCommand = new RelayCommand(Add);
            AllProductsCommand = new(All);

            DbContext = dbContext;
        }

        private void All(object? obj)
        {
            CurrentPage = App.Container.GetInstance<AllProductsView>();
            CurrentPage.DataContext = App.Container.GetInstance<AllProductsViewModel>();
        }

        public void Add(object? parameter)
        {
            CurrentPage = App.Container.GetInstance<AddProductView>();
            CurrentPage.DataContext = App.Container.GetInstance<AddProductViewModel>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
