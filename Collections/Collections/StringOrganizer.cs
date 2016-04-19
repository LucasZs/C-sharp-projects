using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class StringOrganizer
    {
        static void Main(string[] args)
        {
            string firstString = null;
            string secondString = null;
            string thirdString = null;

            while (firstString == null)
            {
                Console.WriteLine("Enter a string:");
                firstString = Console.ReadLine();
            }

            while (secondString == null)
            {
                Console.WriteLine("Enter a second string:");
                secondString = Console.ReadLine();
            }

            while (thirdString == null)
            {
                Console.WriteLine("Enter a third string:");
                thirdString = Console.ReadLine();
            }

            ArrayList myStringCollection = new ArrayList();
            myStringCollection.Add(firstString);
            myStringCollection.Add(secondString);
            myStringCollection.Add(thirdString);

            Console.WriteLine("The given strings are the following:");
            foreach (string item in myStringCollection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
