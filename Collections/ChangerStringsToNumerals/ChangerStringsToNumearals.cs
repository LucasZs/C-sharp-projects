using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangerStringsToNumerals
{
    class ChangerStringsToNumearals
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> numDict = new Dictionary<string, string>
            {
                {"one", "1"},
                {"two", "2"},
                {"three", "3"}

            };

            string givenString = null;

            Console.WriteLine("Please enter word 'one', 'two' or 'three'");
            givenString = Console.ReadLine().ToLower();

            if (givenString.Equals("one"))
            {
                numDict.TryGetValue("one", out givenString);
                Console.WriteLine("The choosen number in form of a numeral: " + givenString);
                Console.ReadKey();
            }
            else if (givenString.Equals("two"))
            {
                numDict.TryGetValue("two", out givenString);
                Console.WriteLine("The choosen number in form of a numeral: " + givenString);
                Console.ReadKey();
            }
            else if (givenString.Equals("three"))
            {
                numDict.TryGetValue("three", out givenString);
                Console.WriteLine("The choosen number in form of a numeral: " + givenString);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong input! Unalble to convert to numerals. Please run this program again and follow the starter instruction. Thank you!");
                Console.ReadKey();
            }
        }
    }
}
