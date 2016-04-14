using System;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("1", "one");
            hashTable.Add("2", "two");
            hashTable.Add("3", "three");
            hashTable.Add("4", "four");
            hashTable.Add("5", "five");
            hashTable.Add("6", "six");
            hashTable.Add("7", "seven");
            hashTable.Add("8", "eight");
            hashTable.Add("9", "nine");

            string digits = "12345";
            
            foreach (char digit in digits)
            {
                string digitAsString = digit.ToString();
                if (hashTable.ContainsKey(digitAsString))
                {
                    Console.WriteLine(hashTable[digitAsString]);
                }
            }

        }
    }
}
