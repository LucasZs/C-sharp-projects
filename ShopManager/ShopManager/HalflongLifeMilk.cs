using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager
{
    public class HalflongLifeMilk : Milk
    {
        public HalflongLifeMilk(long barcode, int capacity, string company, DateTime warrant, double dripping) :
            base(barcode, capacity, company, warrant, dripping)
        {

        }
    }
}
