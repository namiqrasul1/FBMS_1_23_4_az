using Lesson15WpfCoding.ViewModels;
using System.Windows.Controls;

namespace Lesson15WpfCoding.Services
{
    public interface INavigationService
    {
        void Navigate<TView, TViewModel>() where TView : Page where TViewModel : ViewModel;
    }
}
