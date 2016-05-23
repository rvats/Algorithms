using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Algorithms;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "Y";
            while (choice.Equals("y")|| choice.Equals("Y"))
            {
                string line = "";
                Console.Write("Please Enter A String: ");
                line = Console.ReadLine();
                if (Technossus.IsStringPalindrome(line))
                {
                    Console.WriteLine(line + " is a palindrome.");
                }
                else
                {
                    Console.WriteLine(line + " is not a palindrome.");
                }
                Console.Write("Continue (Y/N): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Thread.Sleep(3000);
        }
    }
}
