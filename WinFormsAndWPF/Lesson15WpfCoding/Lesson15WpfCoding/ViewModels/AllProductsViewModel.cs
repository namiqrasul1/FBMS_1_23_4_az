using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Services;
using Lesson15WpfCoding.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15WpfCoding.ViewModels
{
    public class AllProductsViewModel : ViewModel
    {
        private readonly INavigationService navigationService;

        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public AllProductsViewModel(AppDbContext dbContext, INavigationService navigationService)
        {
            DbContext = dbContext;
            this.navigationService = navigationService;
            DeleteCommand = new RelayCommand(DeleteProduct);
            EditCommand = new RelayCommand(EditProduct);


        }

        private void EditProduct(object? id)
        {
            if (id is not null)
            {
                var product = DbContext.GetProduct(id.ToString()!);
                if( product is not null )
                {
                    product = product.Clone();

                    navigationService.Navigate<EditProductView, EditProductViewModel>();

                    var mainVm = App.Current.MainWindow.DataContext as MainViewModel;
                    if (mainVm is not null)
                    {
                        var vm = mainVm.CurrentPage.DataContext as EditProductViewModel;
                        vm!.Product = product;
                    }
                }
                
            }
        }

        private void DeleteProduct(object? id)
        {
            DbContext.RemoveProduct(id!.ToString()!);
        }

        public AppDbContext DbContext { get; set; }


    }
}
