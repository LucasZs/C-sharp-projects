using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager
{
    public class Milk
    {
        //variables:
        long barcode;
        int capacity; //ml
        string company;
        DateTime warrant;
        double dripping;

        //constructor:

        public Milk(long barcode, int capacity, string company, DateTime warrant, double dripping)
        {
            this.barcode = barcode;
            this.capacity = capacity; // mililiter
            this.company = company;
            this.warrant = warrant;
            this.dripping = dripping;
        }

        // getters:

        public long GetBarcode()
        {
            return barcode;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public string GetCompany()
        {
            return company;
        }

        public DateTime GetWarrant()
        {
            return warrant;
        }

        public double GetDripping()
        {
            return dripping;
        }
        
        // other methods:
        public bool IsGood()
        {
            return warrant >= DateTime.Now;
        }

        override public string ToString()
        {
            return "Produced by: " + company + " Best before: " + warrant + " Dripping: " + dripping;
        }
    }

    public class MilkRunner
    {
        static void Main(string[] args)
        {
            Milk mizo = new Milk(645746747, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8);
            Milk parmalat = new Milk(56547777, 1500, "Lactalis Hungária Kft.", new DateTime(2016, 8, 18), 1.5);
            Milk milli = new Milk(547487747447, 330, "FrieslandCampina Hungária ZRt.", new DateTime(2016, 9, 15), 3.5);

            Console.WriteLine("The warrant date of our Mizo milk is " + mizo.GetWarrant());
            Console.WriteLine("The company behind Parmalat milk is " + parmalat.GetCompany());
            Console.WriteLine("The capacity of our Milli milk is " + milli.GetCapacity() + " litre.");
            Console.WriteLine("Milli milk is " + (milli.IsGood() ? "good" : "bad"));
            Console.ReadKey();
        }
    }
}
