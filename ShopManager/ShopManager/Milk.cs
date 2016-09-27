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
}
