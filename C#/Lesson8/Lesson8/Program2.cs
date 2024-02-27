//using Lesson8.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson8
//{
//    internal class Program2
//    {
//        // Action => return Type = void
//        // Func => return type = all types without void
//        // Predicate return Type = bool but 1 parameter
//        static void Main(string[] args)
//        {
//            //Action<int, string> action = Foo;
//            //action.Invoke(42, "f");
//            //Func<int, int, bool> f =  Any;
//            //Func<char, byte> f1 = A;
//            //Func<GmailService,object, object> f2 = G;
//            Predicate<int> p = F;
//            Console.WriteLine(p.Invoke(0));
            
//        }

//        static bool F(int x) { return x > 10; }

//        static object G(GmailService s, object o) { return new(); }
//        static byte A(char a) { return 1; }
//        static bool Any(int a, int b) { return a > b; }
//        static void Foo(int arg, string str) { Console.WriteLine($"Foo({arg})"); }
//        static void Some(Action<bool, double> action) { }
//    }
//}
