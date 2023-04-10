using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Aprel.Exceptions
{
    internal class FruitIndexOutOfRangeException:Exception
    {
        public FruitIndexOutOfRangeException():base ("Expetion")
        { 
        }
        public FruitIndexOutOfRangeException(string message) : base(message) 
        { 
        }
    }
   
}
