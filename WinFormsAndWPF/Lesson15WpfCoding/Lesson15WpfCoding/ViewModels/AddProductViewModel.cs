using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Models;
using Lesson15WpfCoding.Services;
using Lesson15WpfCoding.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lesson15WpfCoding.ViewModels
{
    public class AddProductViewModel : ViewModel, INotifyPropertyChanged
    {
        private Product product;
        private readonly INavigationService navigationService;

        public Product Product { get => product; set { product = value; OnPropertyChanged(); } }

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public AppDbContext DbContext { get; set; }

        public AddProductViewModel(AppDbContext dbContext, INavigationService navigationService)
        {
            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cancel);
            Product = new();
            DbContext = dbContext;
            this.navigationService = navigationService;
        }

        private void Cancel(object? obj)
        {
            navigationService.Navigate<AllProductsView, AllProductsViewModel>();
            Thread.Sleep(15000);
        }

        private void Save(object? obj)
        {
            DbContext.AddProduct(Product);
            Product = new();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
