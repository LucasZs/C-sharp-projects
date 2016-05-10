using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons_Serializer;

namespace PersonCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Person person = new Person();
                person.ToFile();
            }
        }
    }
}
