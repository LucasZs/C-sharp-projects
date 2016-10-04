using System;

namespace ShopManager
{
    public abstract class Food : Ware
    {
        protected DateTime warrant;

        public Food(long barcode, string company, DateTime warrant) : base(barcode, company)
        {
            this.warrant = warrant;
        }

        public DateTime GetWarrant()
        {
            return warrant;
        }
        
        public bool IsGood()
        {
            return warrant >= DateTime.Now;
        }

        override public string ToString()
        {
            return
                base.ToString() + 
                "\nBest before: " + warrant;
        }
    }
}

