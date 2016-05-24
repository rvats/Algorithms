using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms
{
    delegate bool D();
    delegate bool D2(int i);
    delegate int Square(int i);

    class Lambda
    {
        public D del;
        public D2 del2;
        public void TestMethod(int input)
        {
            int j = 0;
            // Initialize the delegates with lambda expressions.
            // Note access to 2 outer variables.
            // del will be invoked within this method.
            del = () => { j = 10; return j > input; };

            // del2 will be invoked after TestMethod goes out of scope.
            del2 = (x) => { return x == j; };

            // Demonstrate value of j:
            // Output: j = 0 
            // The delegate has not been invoked yet.
            Console.WriteLine("j = {0}", j);        // Invoke the delegate.
            bool boolResult = del();

            // Output: j = 10 b = True
            Console.WriteLine("j = {0}. b = {1}", j, boolResult);
        }

        public static void TestLambda()
        {
            Square myDelegate = y => y * y;
            int j = myDelegate(5);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
//At the end of each file there are sample use cases which can be entered into the main program to run the code.
/*
 * string choice = "Y";
            while (choice.Equals("y") || choice.Equals("Y"))
            {
                Lambda test = new Lambda();
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
 */
