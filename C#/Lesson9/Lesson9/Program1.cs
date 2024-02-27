//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson9
//{
//    class Data<T>
//    {
//        public T? Value { get; set; }
//    }

//    class Pair<TKey, TValue>
//    {
//        public Pair(TKey key, TValue value)
//        {
//            Key = key;
//            Value = value;
//        }

//        public TKey Key { get; set; }
//        public TValue Value { get; set; }

//    }

//    class Some<T> where T : struct
//    {
//        public T MyProperty { get; set; }
//    }

//    class Any<T> where T : class, new()
//    {
//        private T _value;
//    }

//    class Any1<T> where T : IEnumerable<char>
//    {
//        private T _value;
//    }

//    interface IInerface { }
//    interface IB : IInerface { }
//    class A : IInerface { }
//    class B : A { }
//    class C : B { }

//    class Any2<T> where T: IInerface, new()
//    {

//    }

//    internal class Program1
//    {
//        //static TResult TemplateMethod<T, TResult>(T arg)
//        //{
//        //    Console.WriteLine(typeof(T));
//        //    return null;
//        //}
//        static void Main(string[] args)
//        {
//            Any2<C> any;
//            //TemplateMethod<int, object>(4);
//            //Data<float> data = new Data<float>();
//            //data.Value = 1.2; // Type error
//            //Data<int> data1 = new();
//            //var data2 = new Data<int>();
//            //Console.WriteLine();
//            //var pair = new Pair<int, string>(1, "kamil");
//            Some<int> some = new();
//            //Any<string> some1 = new();
//            //Any<ICloneable> some2 = new();
//            Any1<string> any1 = new();
//            Any1<List<char>> any2 = new();
            
//        }
//    }
//}
