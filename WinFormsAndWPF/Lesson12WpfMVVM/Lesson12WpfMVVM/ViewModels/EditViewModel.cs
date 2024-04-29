using Lesson12WpfMVVM.Commands;
using Lesson12WpfMVVM.Models;
using Lesson12WpfMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12WpfMVVM.ViewModels
{
    public class EditViewModel
    {
        public EditView currentView;
        public Book? Book { get; set; }

        public RelayCommand SaveCommand { get; set; }

        public EditViewModel()
        {
            SaveCommand = new RelayCommand(
                parameter => { currentView!.DialogResult = true; },
                param =>
                {
                    return !string.IsNullOrWhiteSpace(Book.Name) && !string.IsNullOrWhiteSpace(Book.Author) && Book.PublishYear < 2024;
                }
                );
        }
    }
}
