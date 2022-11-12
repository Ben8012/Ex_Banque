using Ex_Banque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Interfaces
{
    internal interface IBanker
    {
        void ApplyInterest();

        Person Owner { get;  }
        string Number { get;  }
    }
}
