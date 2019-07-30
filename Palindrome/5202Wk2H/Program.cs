using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Wk2H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first letter of 3 letter Palindrome.");
            string letter1 = Console.ReadLine();
            Console.WriteLine("Input second letter of 3 letter Palindrome.");
            string letter2 = Console.ReadLine();

            if (letter2 != "a" && letter2 != "e" && letter2 != "i" && letter2 != "o" && letter2 != "u")
                Console.WriteLine("All English palindromes demand a vowel.");
            else Console.WriteLine("Input third letter of 3 letter Palindrome.");
            string letter3 = Console.ReadLine();

            if (letter1 == letter3) Console.WriteLine("The palindrome "+letter1+letter2+letter3+" appears.");
            else Console.WriteLine(letter1 + letter2 + letter3 + " is not a palindrome. You have failed the Fatherland.");

            Console.ReadLine();
        }
    }
}
