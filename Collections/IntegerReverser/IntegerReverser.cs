using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerReverser
{
    class IntegerReverser
    {
        static void Main(string[] args)
        {
            string firstGivenInteger;
            string secondGivenInteger;
            string thirdGivenInteger;


            int firstGivenIntegerParsed;
            int secondGivenIntegerParsed;
            int thirdGivenIntegerParsed;

            Console.WriteLine("Enter an integer:");
            firstGivenInteger = Console.ReadLine();
            int.TryParse(firstGivenInteger, out firstGivenIntegerParsed);

            Console.WriteLine("Enter a second integer:");
            secondGivenInteger = Console.ReadLine();
            int.TryParse(secondGivenInteger, out secondGivenIntegerParsed);

            Console.WriteLine("Enter an integer:");
            thirdGivenInteger = Console.ReadLine();
            int.TryParse(thirdGivenInteger, out thirdGivenIntegerParsed);

            Stack myStack = new Stack();
            myStack.Push(firstGivenIntegerParsed);
            myStack.Push(secondGivenIntegerParsed);
            myStack.Push(thirdGivenIntegerParsed);

            Console.WriteLine("The integers in reversed sequence of entering are the following:");
            foreach (int integer in myStack)
            {
                Console.WriteLine(integer);
            }
            Console.ReadKey();
        }
    }
}
