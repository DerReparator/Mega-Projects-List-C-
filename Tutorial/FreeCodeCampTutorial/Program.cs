using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32("45");
            Console.Write("Enter something: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("You entered: " + userInput);
            Console.ReadLine();
        }
    }
}
