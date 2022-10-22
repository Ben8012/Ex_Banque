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
    internal class CurrentAccount : Account
    {


        public CurrentAccount(string number, double balance, double creditLine, Person owner) : base(number, balance, creditLine, owner)
        {

        }
        protected override double CalculInterets()
        {
            if(Balance >= 0)
                return  Balance * 0.03;
            return  Balance * 0.0975;
        }

    }
}
