using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;         

namespace ThreadPool_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);   


            ThreadPool.QueueUserWorkItem(callback, "Athos");
            ThreadPool.QueueUserWorkItem(callback, "Porthos");
            ThreadPool.QueueUserWorkItem(callback, "Aramis");
            ThreadPool.QueueUserWorkItem(callback, "D'Artagnan");

            Console.Read();

        }

        static void ShowMyText(object state)   
        {
            string myText = (string)state;      
            Console.WriteLine("Thread: {0} - {1}", Thread.CurrentThread.ManagedThreadId, myText);
        }
    }
}
