using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;         //{2} Include the System.Threading namespace.

namespace ThreadPoolDemo //{1} Create a blank console application with the name ThreadPoolDemo.
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);   //{6} In the Main method of the console application, create a new instance of the WaitCallback delegate that refers to the ShowMyText method.


            ThreadPool.QueueUserWorkItem(callback, "Homer");    //{7} Use the ThreadPool to queue up several calls to the WaitCallback delegate, specifying different strings as the object state.
            ThreadPool.QueueUserWorkItem(callback, "Marge");
            ThreadPool.QueueUserWorkItem(callback, "Bart");
            ThreadPool.QueueUserWorkItem(callback, "Lisa");
            ThreadPool.QueueUserWorkItem(callback, "Maggie");

            Console.Read();

        }

        static void ShowMyText(object state)    //{3} Create a new method to simply display some text. Call it ShowMyText. Accept one parameter of type object, and call it state.
        {
            string myText = (string)state;      //{4} Create a new string variable inside the ShowMyText method, and cast the state parameter to a string while storing it in the new text variable.
            Console.WriteLine("Thread: {0} - {1}",      //{5} Inside the ShowMyText method, write out the ManagedThreadId of the current thread and write the new string out to the console.
            Thread.CurrentThread.ManagedThreadId, myText);
        }
    }
}
