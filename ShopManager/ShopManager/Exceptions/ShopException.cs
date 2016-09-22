using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Exceptions
{
    public class ShopException : System.Exception
    {
        // Default constructor
        public ShopException() : base()
        {
        }

        // Argument constructor
        public ShopException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        // Argument constructor with inner exception
        public ShopException(string message, Exception innerException) : base(message, innerException)
        {
        }

        // Argument constructor with serialization support
        protected ShopException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
