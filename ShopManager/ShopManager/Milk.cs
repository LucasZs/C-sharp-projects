using System;

namespace ShopManager
{
    public abstract class Milk : Food
    {
        //variables:
        protected int capacity; //ml
        protected double dripping;

        //constants:
        public static readonly int LITER = 1000;
        public static readonly int HALF_LITER = 500;
        public static readonly int CUP = 200;
        public static readonly double HALF_FAT = 1.5;
        public static readonly double FAT = 2.8;

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


        public override string ToString()
        {
            return
                base.ToString() + 
                "\nCapacity: " + capacity + 
                "\nDripping: " + dripping;
        }
    }
}
