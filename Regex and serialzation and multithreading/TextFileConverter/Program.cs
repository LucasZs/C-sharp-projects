using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\boot.ini");
                StreamWriter sw = new StreamWriter("boot-utf7.txt", false, Encoding.UTF7);

                sw.WriteLine(sr.ReadToEnd());
                sw.Close();
                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
