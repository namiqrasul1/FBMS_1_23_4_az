using Lesson15WpfCoding.Data;
using Lesson15WpfCoding.Services;
using Lesson15WpfCoding.ViewModels;
using Lesson15WpfCoding.Views;
using SimpleInjector;
using System.Windows;

namespace Lesson15WpfCoding
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        public App()
        {
            AddOtherServices();
            AddViews();
            AddViewModels();
        }

        private void AddOtherServices()
        {
            Container.RegisterSingleton<AppDbContext>();
            Container.RegisterSingleton<INavigationService, NavigationService>();
        }

        private void AddViewModels()
        {
            Container.RegisterSingleton<AddProductViewModel>();
            Container.RegisterSingleton<AllProductsViewModel>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<EditProductViewModel>();
        }

        private void AddViews()
        {
            Container.RegisterSingleton<MainView>();
            Container.RegisterSingleton<AllProductsView>();
            Container.RegisterSingleton<AddProductView>();
            Container.RegisterSingleton<EditProductView>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = Container.GetInstance<MainView>();
            mainView.DataContext = Container.GetInstance<MainViewModel>();
            mainView.Show();
            base.OnStartup(e);
        }
    }

}
