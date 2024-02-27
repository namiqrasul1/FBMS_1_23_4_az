using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    static class Extension
    {
        public static bool IsPositive(this int i)
        {
            return i > 0;
        }
        public static bool IsPositive(this double i)
        {
            return i > 0;
        }

        public static int WordCount(this string s)
        {
            char[] seperators = new char[] { ' ', ',', '.', '!' };
            return s.Split(seperators, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static Student GetOlderStudent(this List<Student> students)
        {
            Student result = students[0];
            foreach (Student student in students)
            {
                if(result.BDay.CompareTo(student.BDay) == 1) 
                    result = student;
            }
            return result;
        }
    }
}
