using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons_Serializer
{
    class StoringMaxException: Exception
    {
        public StoringMaxException(): base("This program can store the data of max. 99 persons!")
        {
            
        }
    }
}
