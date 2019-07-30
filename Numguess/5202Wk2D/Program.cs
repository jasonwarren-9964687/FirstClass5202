using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int mynum = rand.Next(1, 11);
            Console.WriteLine("Guess My Number between 1 and 10");
            Console.WriteLine("Input guess");
            int usernum = int.Parse(Console.ReadLine());

            if (usernum == mynum) Console.WriteLine("Good Guess");
            else if (usernum > 10) Console.WriteLine("Above 10 Smartarse");
            else if (usernum < 1) Console.WriteLine("Below 1 Smartarse");
            else if (usernum > mynum) Console.WriteLine("Too High");
            else if (usernum < mynum) Console.WriteLine("Too Low");
            Console.ReadLine();
        }
    }
}
