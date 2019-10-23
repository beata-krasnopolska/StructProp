using System;

namespace StructProp
{
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
