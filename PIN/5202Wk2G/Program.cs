using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2G
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 digit PIN");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 9999 || num1 < 1000) Console.WriteLine("Invalid PIN");
            else Console.WriteLine("Reenter PIN");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2) Console.WriteLine("PIN is now set");
            else if(num1 != num2) Console.WriteLine("Error, PIN is not set");
            Console.ReadLine();
        }
    }
}
