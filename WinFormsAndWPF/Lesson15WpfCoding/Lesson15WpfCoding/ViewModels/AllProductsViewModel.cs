using Lesson15WpfCoding.Commands;
using Lesson15WpfCoding.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15WpfCoding.ViewModels
{
    public class AllProductsViewModel
    {
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public AllProductsViewModel(AppDbContext dbContext)
        {
            DbContext = dbContext;
            DeleteCommand = new RelayCommand(DeleteProduct);
            EditCommand = new RelayCommand(EditProduct);


        }

        private void EditProduct(object? obj)
        {
            
        }

        private void DeleteProduct(object? id)
        {
            DbContext.RemoveProduct(id!.ToString()!);
        }

        public AppDbContext DbContext { get; set; }


    }
}
