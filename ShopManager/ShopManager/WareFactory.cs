using System;

namespace ShopManager
{
    public abstract class WareFactory
    {
        public static Milk CreateNewHalflonglifeMilk(long barcode, int capacity, string company, DateTime warrant, double dripping)
        {
            return new LonglifeMilk(barcode, capacity, company, warrant, dripping);
        }

        public static Milk CreateNewHalfFatLonglifeMilk(long barcode, int capacity, string company, DateTime warrant)
        {
            return new LonglifeMilk(barcode, capacity, company, warrant, Milk.HALF_FAT);
        }

        public static Milk CreateNewLiterHalfFatLonglifeMilk(long barcode, string company, DateTime warrant)
        {
            return new LonglifeMilk(barcode, Milk.LITER, company, warrant, Milk.HALF_FAT);
        }

        public static Milk CreateNewFatLonglifeMilk(long barcode, int capacity, string company, DateTime warrant)
        {
            return new LonglifeMilk(barcode, capacity, company, warrant, Milk.FAT);
        }

        public static Milk CreateNewLiterFatLonglifeMilk(long barcode, string company, DateTime warrant)
        {
            return new LonglifeMilk(barcode, Milk.LITER, company, warrant, Milk.FAT);
        }

        public static Milk CreateNewHalflongLifeMilk(long barcode, int capacity, string company, DateTime warrant, double dripping)
        {
            return new HalflongLifeMilk(barcode, capacity, company, warrant, dripping);
        }

        public static Milk CreateNewHalfFatHalflonglifeMilk(long barcode, int capacity, string company, DateTime warrant)
        {
            return new HalflongLifeMilk(barcode, capacity, company, warrant, Milk.HALF_FAT);
        }

        public static Milk CreateNewFatHalflongLifeMilk(long barcode, int capacity, string company, DateTime warrant)
        {
            return new HalflongLifeMilk(barcode, capacity, company, warrant, Milk.FAT);
        }

        public static Milk CreateNewLiterHalfFatHalflongLifeMilk(long barcode, string company, DateTime warrant)
        {
            return new HalflongLifeMilk(barcode, Milk.LITER, company, warrant, Milk.HALF_FAT);
        }

        public static Milk CreateNewLiterFatHalflongLifeMilk(long barcode, string company, DateTime warrant)
        {
            return new HalflongLifeMilk(barcode, Milk.LITER, company, warrant, Milk.FAT);
        }

        public static Soap CreateNewSoap(long barcode, string company, char washEffect)
        {
            return new Soap(barcode, company, washEffect);
        }

        public static Soap CreateNewSoapWithWashEffectA(long barcode, string company)
        {
            return new Soap(barcode, company, Soap.WASHEFFECT_A);
        }
    }
}
