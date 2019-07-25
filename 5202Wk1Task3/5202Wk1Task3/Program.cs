using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk1Task3
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Input first whole number.");
            int numa = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second whole number.");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Input first decimal number.");
            double deca = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second decimal number.");
            double decb = double.Parse(Console.ReadLine());
            Console.WriteLine("Input first string.");
            string stra = Console.ReadLine();
            Console.WriteLine("Input second string.");
            string strb = Console.ReadLine();
            Console.WriteLine($"\n{numa} \n{numb} \n{deca} \n{decb} \n{stra} \n{strb}");
            Console.ReadLine();
        }
    }
}
