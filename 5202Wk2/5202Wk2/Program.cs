using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            double num2 = double.Parse(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine(num1+" + "+num2+" = "+result);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            Console.ReadLine();
        }
    }
}
