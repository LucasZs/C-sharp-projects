using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager
{
    public abstract class Ware
    {
        protected long barcode;
        protected string company;

        public Ware(long barcode, string company)
        {
            this.barcode = barcode;
            this.company = company;
        }

        public long GetBarcode()
        {
            return barcode;
        }

        public string GetCompany()
        {
            return company;
        }
    }
}
