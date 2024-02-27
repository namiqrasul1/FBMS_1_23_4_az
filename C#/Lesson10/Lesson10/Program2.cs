//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

//namespace Lesson10
//{
//    internal class Program2
//    {
//        static void Main(string[] args)
//        {
//            List<Student> students = new()
//            {
//                new Student {
//                    Name  = "Mirali",
//                    Surname = "Irali",
//                    BDay = new DateOnly(2007, 11, 1)
//                },
//                new Student {
//                    Name  = "Elgun",
//                    Surname = "Asgar",
//                    BDay = new DateOnly(2003, 06, 18) },
//                new Student {
//                    Name  = "Logman",
//                    Surname = "Hakim",
//                    BDay = new DateOnly(2007, 03, 06) },
//                new Student {
//                    Name  = "Zeynal",
//                    Surname = "Meshgul",
//                    BDay = new DateOnly(2005, 10, 02) },
//            };

//            //var older = students.GetOlderStudent();

//            //Console.WriteLine(older);

//            // IEnumerable    

//            //var student = students.First(s => s.Name == "Mira");
//            //var student = students.FirstOrDefault(s => s.Name == "Mira");
//            //if (student is not null)
//            //    student.Name = "mir";

//            //var avg = students.Average(s => s.BDay.Year);
//            //Console.WriteLine(avg);

//            //var orderedList = students.OrderBy(student => student.BDay);

//            //var names = students.Select(s => s.Surname).ToList();
//            //foreach (var name in names)
//            //{
//            //    Console.WriteLine(name);
//            //}

//            //var dtos =  students.Select(s => new StudentDto(s.Name, s.Surname)).ToList();

//            // foreach (var item in dtos)
//            // {
//            //     Console.WriteLine($"{item.Name} {item.Surname}");
//            // }

//            //var s = students.Single(s => s.Name.Contains('Q'));
//            //var s = students.SingleOrDefault(s => s.Name.Contains('M'));

//            //students = students.Skip(2).ToList();

//            //var sum = students.Sum(s => s.BDay.Day);
//            //Console.WriteLine(sum);

//            //var l = students
//            //    .Where(s => s.Name.Contains('a'))
//            //    .Select(s => s.BDay)
//            //    .OrderBy(bd => bd.Year)
//            //    .ToList();

//            //foreach (var item in l)
//            //{
//            //    Console.WriteLine(item);
//            //}


            

//            foreach (var st in students)
//            {
//                Console.WriteLine(st);
//            }




//        }

//    }
//}
