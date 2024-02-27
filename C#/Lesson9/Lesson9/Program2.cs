using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            // generic colloctions
            // non-generic collections



            // non-generic collections
            //var al = new ArrayList();
            //al.Add(2);
            //al.Add(3.5);
            //al.Add("string");
            //al.Add(new User());
            //al[1] = "kamil";
            //var val = al[1] as double?;
            //// value type => reference type ==> boxing
            //// reference type => value type ==> unboxing

            //IEnumerator enumerator = al.GetEnumerator();
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            //enumerator.Reset();
            //enumerator.MoveNext();
            //Console.WriteLine(enumerator.Current);

            // generic colloctions
            //List<int> l = new();

            //l.Add(1);
            //l.Add(20);

            ////IEnumerator<int> e = l.GetEnumerator();
            ////while (e.MoveNext())
            ////{
            ////    Console.WriteLine(e.Current);
            ////}
            ////l.ForEach(delegate (int i) { Console.WriteLine(i); });
            ////int val = l.Find(delegate (int x) { return x == 4; });
            //int val = l.Find(x => x > 10);


            ////string s = "Kamil";
            ////if (s.Contains("K")) { }



            //Action<int> a = delegate (int x) { };
            //Action<int> a1 = (x) => Console.WriteLine(x);
            //Predicate<int> p = (x) => x > 10;

            //Func<object, char, string> f = (x, y) => $"{x} {y}";


            //List<string> l = new();
            //l.Add("kamil");
            //l.Add("hakuna");
            //l.Add("matata");
            //l.Add("john");
            //l.Add("doe");
            //l.Add("fazil");
            //l.Add("nazim");

            //l.ForEach(s => Console.WriteLine(s));
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //l.RemoveAll(s => s.Contains('i'));
            //l.ForEach(s => Console.WriteLine(s));

            
        }
    }
}
