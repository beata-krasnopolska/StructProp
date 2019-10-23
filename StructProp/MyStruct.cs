using System;

namespace StructProp
{
    class MyStruct
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
}
