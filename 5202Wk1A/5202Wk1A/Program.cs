using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk1A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable 0
            Console.WriteLine("Enter First Name");
            string name = Console.ReadLine();
            //Variable 1
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            //Outputs
            Console.WriteLine("Hello {0} {1}, nice to meet you.", name,lname);
            Console.WriteLine("Hello " + name + " " + lname + ", nice to meet you.");
            Console.WriteLine($"Hello {name} {lname}, nice to meet you.");
            Console.ReadLine();
            
        }
    }
}
