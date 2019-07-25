using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first name.");
            string fname = Console.ReadLine();
            Console.WriteLine("Input last name.");
            string lname = Console.ReadLine();
            Console.WriteLine("Input Address.");
            string address = Console.ReadLine();
            Console.WriteLine("Input Age.");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Email.");
            string email = Console.ReadLine();
            Console.WriteLine("Input 4 Digit PIN.");
            int PIN = int.Parse(Console.ReadLine());
            Console.WriteLine(fname + " " + lname);
            Console.WriteLine(address);
            Console.WriteLine(age);
            Console.WriteLine(email);
            Console.WriteLine(PIN);
            Console.ReadLine();
        }
    }
}
