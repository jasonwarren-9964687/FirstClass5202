using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202WK1B
{
    class Program
    {
        static void Main(string[] args)
            //first name, last name, display both
        { Console.WriteLine("Input first name. ");
            string fname = Console.ReadLine();
            Console.WriteLine("Input last name, ");
            string lname = Console.ReadLine();
            Console.WriteLine("hello " + fname + " " + lname);
            Console.ReadLine();
        }
    }
}
