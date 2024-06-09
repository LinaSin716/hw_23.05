using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_23._05
{
    public class NoPositiveNumbersException : Exception
    {
        public NoPositiveNumbersException(string message) : base(message) { }
    }
}
