//using System.Collections;

//namespace Lesson8;

//class Student : IComparable<Student>
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public DateTime BDay { get; set; }

//    public object Clone() =>
//        new Student { BDay = this.BDay, Name = Name, Surname = Surname };

//    public int CompareTo(Student? other)
//    {
//        //if (other is null ) return 1;
//        //return BDay.CompareTo( other.BDay );
//        return other is null ? 1 : BDay.CompareTo(other.BDay);
//    }
//}

//class Group : IEnumerable<Student>
//{
//    public List<Student> Students { get; set; } = new()
//    {
//         new()
//        {
//            Name = "Hakuna",
//            Surname = "Matata",
//            BDay = new DateTime(1942, 12, 12)
//        },
//          new()
//        {
//            Name = "Hakuna",
//            Surname = "Matata",
//            BDay = new DateTime(1942, 12, 12)
//        },
//           new()
//        {
//            Name = "Hakuna",
//            Surname = "Matata",
//            BDay = new DateTime(1942, 12, 12)
//        }
//    };

//    public IEnumerator<Student> GetEnumerator() => Students.GetEnumerator();

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        throw new NotImplementedException();
//    }
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Student student = new()
//        {
//            Name = "Hakuna",
//            Surname = "Matata",
//            BDay = new DateTime(1942, 12, 12)
//        };
//        Console.WriteLine(student.CompareTo(new Student()));

//        var st = student.Clone() as Student;

//        st!.Surname = "fazil";
//        Console.WriteLine(st?.Surname);
//        Console.WriteLine(student.Surname);
//        //Group group = new();
//        //foreach (var student in group)
//        //{
//        //    Console.WriteLine(student.Name);
//        //}
//    }
//}

