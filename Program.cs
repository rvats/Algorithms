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
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Threads t = new Threads();
            t.Beta();
            t.CurrentThread();
            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
            ThreadStart childref = new ThreadStart(ThreadCreationProgram.CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();

            //stop the main thread for some time
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");

            childThread.Abort();
            Console.ReadKey();
        }

    }
}
