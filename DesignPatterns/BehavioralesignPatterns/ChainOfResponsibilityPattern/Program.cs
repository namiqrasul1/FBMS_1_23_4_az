using ChainOfResponsibilityPattern.Concretes;
using ChainOfResponsibilityPattern.Models;


var human = new Human
{
    Email = "Kamilgmail.com",
    Username = "kamilmtata",
    Password = "kamil123"
};

CheckerDirector director = new();
var checker = director.MakeHumanChecker();

checker?.Check(human);
