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
            while (choice.Equals("y") || choice.Equals("Y"))
            {
                string line = "";

                Console.Write("Please Enter A Number: ");
                line = Console.ReadLine();

                //string reverse;
                //reverse = Technossus.ReverseString(line);
                //Console.WriteLine(reverse);

                Technossus.IsStringPalindromeUsingThreading(line);
                //if (Technossus.IsStringPalindrome(line))
                //{
                //    Console.WriteLine(line + " is a palindrome.");
                //}
                //else
                //{
                //    Console.WriteLine(line + " is not a palindrome.");
                //}

                //int number = 0;
                //if(int.TryParse(line, out number))
                //{
                //    if(Technossus.IsNumberPrime(number))
                //    {
                //        Console.WriteLine("{0} is Prime",number);
                //    }
                //    else
                //    {
                //        Console.WriteLine("{0} is Not Prime", number);
                //    }
                //}
                Console.Write("Continue (Y/N): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
        }

    }
}
