using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Exceptions
{

    public class NonexistentWareException : ShopException
    {
        public NonexistentWareException(string message) : base(message)
        {

        }
    }
}