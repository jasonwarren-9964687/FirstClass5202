using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2) Console.WriteLine(num1 + " is larger");
            else if (num1 < num2) Console.WriteLine(num2 + " is larger");
            else if (num1 == num2) Console.WriteLine("The numbers are the same");
            Console.ReadLine();
        }
    }
}
