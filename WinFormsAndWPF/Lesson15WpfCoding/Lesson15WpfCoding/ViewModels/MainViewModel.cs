using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Services;
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
    public class MainViewModel : ViewModel, INotifyPropertyChanged
    {
        public RelayCommand AddCommand { get; set; }
        public RelayCommand AllProductsCommand { get; set; }
        public AppDbContext DbContext { get; set; }

        private Page currentPage;
        private readonly INavigationService navigationService;

        public Page CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value;  OnPropertyChanged(); }
        }

        public MainViewModel(AppDbContext dbContext, INavigationService navigationService)
        {
            AddCommand = new RelayCommand(Add);
            AllProductsCommand = new(All);
            currentPage = App.Container.GetInstance<AllProductsView>();
            currentPage.DataContext = App.Container.GetInstance<AllProductsViewModel>();
            DbContext = dbContext;
            this.navigationService = navigationService;
        }

        private void All(object? obj)
        {
            navigationService.Navigate<AllProductsView, AllProductsViewModel>();
        }

        public void Add(object? parameter)
        {
            navigationService.Navigate<AddProductView, AddProductViewModel>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
