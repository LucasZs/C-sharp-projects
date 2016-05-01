using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;     //{2} In the main code file, include System.Threading.

namespace SingleInstance    //{1} Create a new console application called SingleInstance.
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex oneMutex = null;  //{3} In the main method of the console application, create a local Mutex variable and assign it a null.
            const string MutexName = "RUNMEONLYONCE";   //{4} Create a constant string to hold the name of the shared Mutex. Make the value "RUNMEONCE".

            try    //{5} Create a try/catch block.
            {
                oneMutex = Mutex.OpenExisting(MutexName);   //{6} Inside the try section of the try/catch block, call the Mutex.OpenExisting method, using the constant string defined in step 4 as the name of the Mutex. Then assign the result to the Mutex variable created in step 2.
            }
            catch (WaitHandleCannotBeOpenedException)   //{7} For the catch section of the try/catch block, catch a WaitHandleCannotBeOpenedException to determine that the named Mutex doesn't exist.
            {
            }
                                                        //{8} Next, test the Mutex variable created in step 2 for null to see whether the Mutex could be found.
            if (oneMutex == null)
            {
                oneMutex = new Mutex(true, MutexName);  //{9} If the Mutex was not found, create the Mutex with the constant string.
            }
            else
            {                                           //{10} If the Mutex was found, close the Mutex variable and exit the application.
                oneMutex.Close();
                return;
            }

        }
    }
}
