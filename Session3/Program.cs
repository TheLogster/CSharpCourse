using System;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TestClass(99);
            var b = t as BaseClass;

            t.Data = 102;
            t.Display();
            Console.WriteLine();
            Console.WriteLine();

            b.Display();

            var c = TestClass.CreateNewDisplay();
            c.Display();
        }
    }
}
