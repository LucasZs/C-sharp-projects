using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //{3} In the new class, add an include statement (or the Imports statement for Visual Basic) to the System.Threading namespace.
using System.Threading.Tasks;

namespace SimpleThreadingDemo   //{1} Create a new console application, and call it SimpleThreadingDemo.
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);    //{7} Go back to the Main method, and create a new StartThread delegate that points to the Counting method.
            Thread first = new Thread(starter);     //{8} Now create two threads,
            Thread second = new Thread(starter);    //each pointing to the Counting method.

            first.Start();      //{9} Start both threads.
            second.Start();


            first.Join();       //{10} Join both threads to ensure that the application doesn't complete until the threads are done.
            second.Join();

            Console.Read();
        }

        static void Counting()          //{2} Create a new static method called Counting.
        {
            for (int i = 1; i <= 10; i++)   //{4} In the new method, create a for loop that counts from 1 to 10.
            {
                Console.WriteLine("Count: {0} - Thread: {1}", i, Thread.CurrentThread.ManagedThreadId); //{5} Within the new for loop, write out the current count and the ManagedThreadId for the current thread.
                Thread.Sleep(10);   //{6} After writing out to the console, sleep the current thread for 10 milliseconds.
            }
        }
    }
}
