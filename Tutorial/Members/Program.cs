using System;

namespace Members
{
    class TestClass
    {
        static int intValue;
        string name;

        static void MyMethod()
        {
            intValue = 6;
        }
    }

    class Calculator
    {
        public Calculator()
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x = calc.Add(4, 6);
        }
    }
}
