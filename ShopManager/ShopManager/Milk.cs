using System;

namespace ShopManager
{
    public abstract class Milk : Food
    {
        //variables:
        protected int capacity; //ml
        protected double dripping;

        //constants:
        public readonly int LITER = 1000;
        public readonly int HALF_LITER = 500;
        public readonly int CUP = 200;
        public readonly double HALF_FAT = 1.5;
        public readonly double FAT = 2.8;

        //constructor:

        public Milk(long barcode, int capacity, string company, DateTime warrant, double dripping) :
            base(barcode, company, warrant)
        {
            this.capacity = capacity;
            this.dripping = dripping;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public double GetDripping()
        {
            return dripping;
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
            LonglifeMilk mizo = new LonglifeMilk(645746747, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8);
            LonglifeMilk parmalat = new LonglifeMilk(56547777, 1500, "Lactalis Hungária Kft.", new DateTime(2016, 8, 18), 1.5);
            LonglifeMilk milli = new LonglifeMilk(547487747447, 330, "FrieslandCampina Hungária ZRt.", new DateTime(2016, 9, 15), 3.5);

            Console.WriteLine("The warrant date of our Mizo milk is " + mizo.GetWarrant());
            Console.WriteLine("The company behind Parmalat milk is " + parmalat.GetCompany());
            Console.WriteLine("The capacity of our Milli milk is " + milli.GetCapacity() + " litre.");
            Console.WriteLine("Milli milk is " + (milli.IsGood() ? "good" : "bad"));
            Console.ReadKey();
        }
    }
}
