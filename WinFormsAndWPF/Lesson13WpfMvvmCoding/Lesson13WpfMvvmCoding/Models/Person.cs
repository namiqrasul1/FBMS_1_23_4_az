using System.CodeDom;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lesson13WpfMvvmCoding.Models;

public class Person : INotifyPropertyChanged, ICloneable
{
    private string name;
    private string surname;
    private DateTime dateOfBirth = DateTime.Now;

    public string Name { get => name; set { name = value; OnPropertyChanged(); } }
    public string Surname { get => surname; set { surname = value; OnPropertyChanged(); } }
    public DateTime DateOfBirth { get => dateOfBirth; set { dateOfBirth = value; OnPropertyChanged(); } }

    public bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Surname);


    // -----------------------------------------------------------------
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }

    public object Clone()
    {
        return new Person()
        {
            Name = this.Name,
            Surname=this.Surname,
            DateOfBirth=this.DateOfBirth,        
        };
    }
    // -----------------------------------------------------------------

    public void SetValue(Person p)
    {
        Name = p.Name;
        Surname = p.Surname;
        DateOfBirth = p.DateOfBirth;
    }


    // == Operator overloading
    public static bool operator==(Person p1, Person p2)
    {
        return (p1.name == p2.name && p1.surname == p2.surname && p1.dateOfBirth == p2.dateOfBirth);
    }

    public static bool operator !=(Person p1, Person p2)
    {
        return !(p1 == p2);
    }
}
