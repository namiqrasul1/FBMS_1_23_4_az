using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Program4
    {
        List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int this[int index]
        {
            get => list[index];
            set { list[index] = value; }
        }
        public int MyProperty { get; set; }
        public static bool operator==(Program4 left, Program4 right)
        {
            return left.MyProperty == right.MyProperty;
        }
        public static bool operator !=(Program4 left, Program4 right)
        {
            return left.MyProperty != right.MyProperty;
        }

        static void Main(string[] args)
        {
            //Program4 p = new();
            //p = new();
            //p is null

            //Program4 p = new();
            //Console.WriteLine(p[4]);
            //p[4] = 42;
            //Console.WriteLine(p[4]);

            //var v = new { Text = "salam", F = 2 };


            //Action<int, string> action = delegate (int i, string s)
            //{
            //    Console.WriteLine($"{i} {s}");
            //};
            //action.Invoke(2, "salam");

            Predicate<object> p = delegate (object c) { return c is char; };
            Func<object, bool> f = delegate (object c) { return c is char; };
        }
    }
}
