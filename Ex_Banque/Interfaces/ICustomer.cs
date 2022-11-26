using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Interfaces
{
    internal interface ICustomer
    {
        decimal Balance { get;  }
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
     
    }
}
