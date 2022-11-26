using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Exceptions
{
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException()
        { }

        public InsufficientBalanceException(string message)
            : base(message)
        { }

        public InsufficientBalanceException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
