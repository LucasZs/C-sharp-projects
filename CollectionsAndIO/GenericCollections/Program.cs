using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary[44] = "United Kingdom";
            dictionary[33] = "France";
            dictionary[31] = "Netherlands";
            dictionary[55] = "Brazil";
            dictionary[36] = "Hungary";

            Console.WriteLine("The 36 Code is for " + dictionary[36]);

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine(item);
            }
                
        }
    }
}
