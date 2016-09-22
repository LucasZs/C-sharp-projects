using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Exceptions
{
    public class TooMuchDecrementionException : Exception
    {
        public TooMuchDecrementionException(string message)
        {
        }
    }
}