using System;
using CalcLib;

namespace LinkedInLearningKurs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int result = Calculator.Add(a, b);
            Console.WriteLine($"{a} + {b} = {result}");
        }
    }
}
