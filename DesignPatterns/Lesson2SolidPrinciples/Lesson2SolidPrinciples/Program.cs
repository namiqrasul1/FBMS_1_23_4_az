// See https://aka.ms/new-console-template for more information

//using Lesson2SolidPrinciples;

//AccountViewModel avm = new();
//avm.LoginCommandMethod("a", "matata");

using Lesson2SolidPrinciples.OpenClosePrinciple;
using Lesson2SolidPrinciples.OpenClosePrinciple.Services;
using SimpleInjector;

//var accountVm = new AccountViewModel(new GmailService());
//var accountVm = new AccountViewModel(new YandexMailService());
//var accountVm = new AccountViewModel(new YahooMailService());


Container container = new ();
container.RegisterSingleton<IMailService, YandexMailService>();
container.RegisterSingleton<AccountViewModel>();

var vm = container.GetInstance<AccountViewModel>();
vm.Email = "some";
vm.RegisterCommandMethod();

