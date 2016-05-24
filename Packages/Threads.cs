using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    class Threads
    {
        static int counter = 0;

        // This method that will be called when the thread is started
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }
        }

        // This method that will be called when the thread is started
        public void CurrentThread()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "Algorithms.Threads";// +counter.ToString();
            Console.WriteLine("This is {0}", th.Name);
            counter++;

        }
    }
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");

                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }

            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception " + e.ToString());
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
    }
}

/*
 * Console.WriteLine("Thread Start/Stop/Join Sample");

            Threads oAlpha = new Threads();

            // Create the thread object, passing in the Alpha.Beta method
            // via a ThreadStart delegate. This does not start the thread.
            Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));

            // Start the thread
            oThread.Start();

            // Spin for a while waiting for the started thread to become
            // alive:
            while (!oThread.IsAlive) ;

            // Put the Main thread to sleep for 1 millisecond to allow oThread
            // to do some work:
            Thread.Sleep(1);

            // Request that oThread be stopped
            oThread.Abort();

            // Wait until oThread finishes. Join also has overloads
            // that take a millisecond interval or a TimeSpan object.
            oThread.Join();

            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");

            try
            {
                Console.WriteLine("Try to restart the Alpha.Beta thread");
                oThread.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStateException trying to restart Alpha.Beta. ");
                Console.WriteLine("Expected since aborted threads cannot be restarted.");
            }

            Console.ReadKey();
 */
