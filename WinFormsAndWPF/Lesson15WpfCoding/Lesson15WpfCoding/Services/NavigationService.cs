using Lesson15WpfCoding.ViewModels;
using Lesson15WpfCoding.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lesson15WpfCoding.Services
{
    public class NavigationService : INavigationService
    {
        public void Navigate<TView, TViewModel>() where TView : Page where TViewModel : ViewModel
        {
            var mainVm = App.Current.MainWindow.DataContext as MainViewModel;
            if (mainVm is not null)
            {
                mainVm.CurrentPage = (App.Container.GetInstance<TView>())!;
                mainVm.CurrentPage.DataContext = App.Container.GetInstance<TViewModel>();
            }
        }
    }
}
