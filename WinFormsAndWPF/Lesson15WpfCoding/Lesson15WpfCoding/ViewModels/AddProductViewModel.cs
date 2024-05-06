using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15WpfCoding.ViewModels
{
    public class AddProductViewModel : INotifyPropertyChanged
    {
        private Product product;

        public Product Product { get => product; set { product = value; OnPropertyChanged(); } }

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public AppDbContext DbContext { get; set; }

        public AddProductViewModel(AppDbContext dbContext)
        {
            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cansel);
            Product = new();
            DbContext = dbContext;
        }

        private void Cansel(object? obj)
        {
            throw new NotImplementedException();
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
