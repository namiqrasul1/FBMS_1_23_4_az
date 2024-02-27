//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson10
//{
//    static class Extension
//    {
//        public static bool IsPositive(this int i)
//        {
//            return i > 0;
//        }
//        public static bool IsPositive(this double i)
//        {
//            return i > 0;
//        }

//        public static int WordCount(this string s)
//        {
//            char[] seperators = new char[] { ' ', ',', '.', '!' };
//           return s.Split(seperators, StringSplitOptions.RemoveEmptyEntries).Length;
//        }
//    }
//    internal class Program1
//    {
//        static void Main(string[] args)
//        {
//            int a = 10;
//            a.IsPositive(); // extension method
//            double d = 34.2;
//            d.IsPositive();

//            string s = "asdhsad| asd| as da| sfa| sf| asda|sad|sa|das";
//            Console.WriteLine(s.WordCount());

//            List<int> ints;
//        }
//    }
//}
