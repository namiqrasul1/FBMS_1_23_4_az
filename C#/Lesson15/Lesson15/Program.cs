using Lesson15.Models;
using Serilog;
using System.Text.Json;
using System.Text.RegularExpressions;

//User user = new("Hakuna", new Car(2));
//user.Car.User = user;

//string fileName = @"C:\Users\namiqrasullu\Desktop\u.json";

//string jsonStr = JsonSerializer.Serialize(user);

//File.WriteAllText(fileName, jsonStr);

////var user = JsonSerializer.Deserialize<User>(File.ReadAllText(fileName));

////Console.WriteLine(user.Name);
///

#region Regular Expression (RegEx)

//string name = "H@KUN@";
//if ()
//{

//}

//string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
//string pattern = @"^\+\d{3}\s\d{2}\s\d{3}\s\d{2}\s\d{2}$";
//string pattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

//var regex = new Regex(pattern);


//var str = Console.ReadLine();

//if (regex.IsMatch(str))
//    Console.WriteLine("matched");
//else
//    Console.WriteLine("no matched");

#endregion


#region Log

//var logFile = "app.log";

//try
//{
//	string? str = Console.ReadLine();
//	str = string.IsNullOrWhiteSpace(str) ? throw new ArgumentException("argument is null") : str;
//}
//catch (Exception ex)
//{
//	File.AppendAllText(logFile, ex.Message + "\n");
//}


#endregion


#region SeriLog

//Log.Logger = new LoggerConfiguration()
//            .MinimumLevel.Debug()
//            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm} {Level:u3}] {Message:lj}{NewLine}{Exception}")
//            .CreateLogger();


//Log.Information("some info");

//Log.Warning("some warn");

//Log.Error("some error");


#endregion

#region Event

class Program
{
    public delegate bool DelegateHandler(int arg);
    public static event DelegateHandler NumberStatus;

    static void Main(string[] args)
    {
        //NumberStatus += x => x > 10;

        //Console.WriteLine( NumberStatus.Invoke(3));


    }
}





#endregion