using System;

namespace Session3
{

    internal sealed class TestClass : BaseClass
    {
        public static IDisplay CreateNewDisplay()
        {
            return new TestClass();
        }

        public int Data { get; set; }

        public TestClass()
        {
            Data = 0;
            Name = "TestClass";
        }

        public TestClass(int originalValue)
            : this()
        {
            Data = originalValue;
        }

        public override void Display()
        {
            Console.WriteLine(Data);
            base.Display();
        }
    }
}
