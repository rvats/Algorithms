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
                Test test = new Test();
                test.TestMethod(5);

                // Prove that del2 still has a copy of
                // local variable j from TestMethod.
                bool result = test.del2(10);

                // Output: True
                Console.WriteLine(result);
                Console.Write("Continue (Y/N): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Thread.Sleep(3000);
        }
    }
}
