//namespace Lesson10;

//public delegate void DelegateHandler(int a);

//class Some
//{
//    DelegateHandler handler1;
//}

//class NumberControl
//{
//    public Predicate<int> control;
//    private int myVar;

//    public int MyProperty
//    {
//        get { return myVar; }
//        set
//        {
//            myVar = control.Invoke(value)
//                ? value
//                : throw new ArgumentException("invalid argument");
//        }
//    }

//    public NumberControl(Predicate<int> control)
//    {
//        this.control = control;
//    }
//}

//internal class Program
//{

//    void foo(int a) { Console.WriteLine("foo"); }
//    private static void Main(string[] args)
//    {
//        Program p = new();
//        DelegateHandler handler = (a) => { Console.WriteLine("Lambda ex"); };

//        handler += (a) => { Console.WriteLine("Some method"); };
//        handler += (a) => { Console.WriteLine("Another method"); };
//        handler += p.foo;
//        //handler.Invoke();

//        var list = handler.GetInvocationList().ToList();

//        foreach (var del in list)
//        {
//            Console.WriteLine(del.Method.Name);
//            Console.WriteLine(del.Method.IsStatic);
//            Console.WriteLine(del.Method.ReturnParameter);
//            //Console.WriteLine(del.Method.GetParameters()[0]);
//            foreach (var item in del.Method.GetParameters())
//            {
//                Console.WriteLine(item);
//            }
//        }

//        NumberControl nc = new((x) => x > 10);
//        nc.MyProperty = 15;

//        NumberControl nc1 = new(x => x < 10);
//        nc1.MyProperty = 14;
//    }
//}