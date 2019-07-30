using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Grade Percentage");
            double grade = double.Parse(Console.ReadLine());

            if (grade > 100) Console.WriteLine("Not valid percentage");
            else if (grade < 0) Console.WriteLine("Not valid percentage");
            else if (grade >= 0 && grade < 40) Console.WriteLine("Grade F");
            else if (grade >= 40 && grade < 50) Console.WriteLine("Grade D");
            else if (grade >= 50 && grade < 60) Console.WriteLine("Grade C");
            else if (grade >= 60 && grade < 70) Console.WriteLine("Grade B");
            else if (grade >= 70 && grade < 80) Console.WriteLine("Grade B+");
            else if (grade >= 80 && grade < 90) Console.WriteLine("Grade A");
            else if (grade >= 90 && grade <= 100) Console.WriteLine("Grade A+");
            else Console.WriteLine("You broke something didn't you?");

            Console.ReadLine();
        }
    }
}
