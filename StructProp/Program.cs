using System;

namespace StructProp
{
    struct MyStruct
    {
        private int _number;
        public int No
        {
            get
            {
                return _number;
            }
            set
            {
                if (value < 100)
                    _number = value;
            }
        }
        public void callMethod()
        {
            Console.WriteLine("The stored value is: {0}", _number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program declares a struct with a property, a method, and a private field.");
            MyStruct callStructure = new MyStruct();
            callStructure.No = 10;
            callStructure.callMethod();

            Console.ReadKey();
        }
    }
}
