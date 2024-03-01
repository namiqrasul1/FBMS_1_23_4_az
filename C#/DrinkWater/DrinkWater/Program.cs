using DrinkWater.Models;
using System.Text.Json;


// Gundelik Su ichme normasini tutan program yazin
// Eger istifadeci birinci defe daxil olubsa, Adini, Chekisini daxil edir. Standard olaraq insan her 20kq uchun gunde 1 litr su ichidiyini nezere alin.
// Esas Sehifede hemishe istifadechinin bu gun erzinde neche litr su ichmeli oldugu ve neche litr ichdiyi qeyd olunur. ve elave 2 sechim olur qarshisinda =>{
//  1. Su ichdim
//  2. Tarixche
//  3. Gunu Bitir
// }
// su ichdim sechilerse, istifadechi neche qeder su ichdiyini qeyd edir (meselen 0.3). bundan sonra esas sehifeye qayidir, deyishiklik gorunur.
// Tarixche sechilerse, istifadechinin kechmish gunlerde neche litr su ichdiyi gorunur. (meselen, "27.02.2024: 2l" "28.02.2024: 3.2l")
// gunu bitir sechdikde, hemin gun bitmishe hesab edilir, novbeti gune kechir

// SOLID

internal class Program
{
    static void DrinkWater()
    {
        if (_user is null) throw new ArgumentNullException(nameof(_user));

        if (double.TryParse(Console.ReadLine(), out var litr))
            _user.Current.Litr += litr;
        else
            throw new FormatException("Invalid input");
    }

    static void ShowHistory()
    {
        if (_user is null) throw new ArgumentNullException(nameof(_user));

        foreach (var info in _user.History)
        {
            Console.WriteLine($"{info.Date}: {info.Litr} litr");
        }
        Console.WriteLine("Press [enter] to exit");
        Console.ReadLine();
    }

    static void EndDate()
    {
        if (_user is null) throw new ArgumentNullException(nameof(_user));

        _user.History.Add(_user.Current);
        _user.Current = _user.Current.Clone();
        _user.Current.Date = _user.Current.Date.AddDays(1);
        _user.Current.Litr = 0;

        var json = JsonSerializer.Serialize(_user);
        File.WriteAllText(FILENAME, json);
    }

    private const string FILENAME = "user.json";
    private static User? _user;
    private static void Main(string[] args)
    {
        if (File.Exists(FILENAME))
        {
            var json = File.ReadAllText(FILENAME);
            _user = JsonSerializer.Deserialize<User>(json);
        }
        else
        {
            string? name = Console.ReadLine();
            var check = double.TryParse(Console.ReadLine(), out double weight);
            if (!string.IsNullOrWhiteSpace(name) && check)
            {
                var date = DateTime.Now;
                _user = new User
                {
                    Name = name,
                    Weight = weight,
                    Current = new DateInfo
                    {
                        Date = new DateOnly(date.Year, date.Month, date.Day),
                        Litr = 0
                    },
                };
            }

        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Su Ichdim\n2. Tarixche\n3. Gunu Bitir");
            int ch = int.Parse(Console.ReadLine()!);
            switch (ch)
            {
                case 1:
                    try
                    {
                        Console.Clear();
                        DrinkWater();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(1000);
                    }
                    break;

                case 2:
                    try
                    {
                        Console.Clear();
                        ShowHistory();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(1000);
                    }
                    break;

                case 3:
                    try
                    {
                        Console.Clear();
                        EndDate();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(1000);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}