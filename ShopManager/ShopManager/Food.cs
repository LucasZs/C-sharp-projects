using System;

namespace ShopManager
{
    public abstract class Food
    {
        protected long barcode;
        protected string company;
        protected DateTime warrant;

        public Food(long barcode, string company, DateTime warrant)
        {
            this.barcode = barcode;
            this.company = company;
            this.warrant = warrant;
        }

        public long GetBarcode()
        {
            return barcode;
        }

        public string GetCompany()
        {
            return company;
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
            return "Produced by: " + company + " Best before: " + warrant;
        }
    }
}

