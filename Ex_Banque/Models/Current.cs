using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Models
{
    internal class Current : Account
    {


        public Current(string number, decimal balance, decimal creditLine, Person owner) : base(number, balance, creditLine, owner)
        {

        }
        protected override decimal CalculInterets()
        {
            if(Balance >= 0)
                return  (Balance * 0.03M);
            return  Balance * 0.0975M;
        }

    }
}
