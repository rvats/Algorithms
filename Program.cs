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
            string line = "";
            long square = 0;
            Console.Write("Please Enter Number To Square: ");
            line = Console.ReadLine();
            square = ProkarmaProvidence.Square(line);
            Console.WriteLine("Square of " + line + " is " + square.ToString());
            
            /* Online Test Question 1
             * Input will be a string followed by Another String separated by a comma we have to find if the 
             * string ends with substring followed after ,
             */
            Console.WriteLine("Please Enter A String followed by a comma followed by another string to test the condition:");
            line = Console.ReadLine();
            if(ProkarmaProvidence.SubStringTest(line))
            {
                Console.WriteLine("String ends in SubString");
            }
            else
            {
                Console.WriteLine("String does not end in SubString");
            }

            /* Online Test Question 2
             * Input will be a url, separate the protocol, domain and query from url into output
             */

            /* Online Test Question 3
             * Check for formatted string made of (){}[]
             */

            /* Online Test Question 4 Could not Attempt */

            /* Some Delay to See The Final Results */
            Thread.Sleep(3000);
        }
    }
}
