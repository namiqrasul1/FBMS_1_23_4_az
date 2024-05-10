using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Models;
using Lesson15WpfCoding.Services;
using Lesson15WpfCoding.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15WpfCoding.ViewModels
{
    public class EditProductViewModel : ViewModel, INotifyPropertyChanged
    {
        private Product? product;
        private readonly INavigationService navigationService;

        public EditProductViewModel(AppDbContext dbContext, INavigationService navigationService)
        {
            DbContext = dbContext;
            this.navigationService = navigationService;
            SaveCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
        }
        public Product? Product { get => product; set { product = value; OnPropertyChanged(); } }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public AppDbContext DbContext { get; set; }

        private void Cancel(object? obj)
        {
            navigationService.Navigate<AllProductsView, AllProductsViewModel>();
        }

        private void Edit(object? obj)
        {
            DbContext.UpdateProduct(Product!);
            navigationService.Navigate<AllProductsView, AllProductsViewModel>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
