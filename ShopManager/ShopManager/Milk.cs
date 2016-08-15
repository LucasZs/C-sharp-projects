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
        int capacity; //ml
        string company;
        DateTime warrant;
        double dripping;
        long price; //HUF

        //constructor:

        public Milk(int capacity, string company, DateTime warrant, double dripping, long price)
        {
            this.capacity = capacity; // liter
            this.company = company;
            this.warrant = warrant;
            this.dripping = dripping;
            this.price = price; // Ft
        }

        // getters:

        public int getCapacity()
        {
            return capacity;
        }

        public string getCompany()
        {
            return company;
        }

        public DateTime getWarrant()
        {
            return warrant;
        }

        public double getDripping()
        {
            return dripping;
        }

        public long getPrice()
        {
            return price;
        }

        // other methods:
        public bool isGood()
        {
            return warrant >= DateTime.Now;
        }

        public string toString()
        {
            return "Produced by " + company + " Best before: " + warrant + " Dripping: " + dripping;
        }
    }

    public class MilkRunner
    {
        static void Main(string[] args)
        {
            Milk mizo = new Milk(1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8, 200);
            Milk parmalat = new Milk(1500, "Lactalis Hungária Kft.", new DateTime(2016, 8, 18), 1.5, 259);
            Milk milli = new Milk(330, "FrieslandCampina Hungária ZRt.", new DateTime(2016, 9, 15), 3.5, 179);

            Console.WriteLine("The warrant date of our Mizo milk is " + mizo.getWarrant());
            Console.WriteLine("The company behind Parmalat milk is " + parmalat.getCompany());
            Console.WriteLine("The capacity of our Milli milk is " + milli.getCapacity() + " litre.");
            Console.WriteLine("Milli milk is " + (milli.isGood() ? "good" : "bad"));
            Console.ReadKey();
        }
    }
}
