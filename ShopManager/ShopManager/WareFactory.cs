using System;

namespace ShopManager
{
    public abstract class WareFactory
    {
        public static Milk newLonglifeMilk(long barcode, int capacity, string company, DateTime warrant, double dripping)
        {
            return new LonglifeMilk(barcode, capacity, company, warrant, dripping);
        }

        public static Milk newHalflongLifeMilk(long barcode, int capacity, string company, DateTime warrant, double dripping)
        {
            return new HalflongLifeMilk(barcode, capacity, company, warrant, dripping);
        }

        public static Soap newSoap(long barcode, string company, char washEffect)
        {
            return new Soap(barcode, company, washEffect);
        }
    }
}
