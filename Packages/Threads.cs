using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms
{
    class Threads
    {
        // This method that will be called when the thread is started
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }
        }

        // This method that will be called when the thread is started
        public void MultiThreadedPalindrome()
        {

        }


    }
}