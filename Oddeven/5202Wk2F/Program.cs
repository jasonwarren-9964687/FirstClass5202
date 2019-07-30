using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input whole number");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 == 0) Console.WriteLine("The Universe will now implode"); 
            else if (num1 % 2 == 0) Console.WriteLine("Number is Even");
            else if (num1 % 2 != 0) Console.WriteLine("Number is Odd");

            Console.ReadLine();
        }
    }
}
