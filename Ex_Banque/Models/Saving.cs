using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Models
{
    internal class Saving : Account
    {

        public Saving(string number, double balance, double creditLine, Person owner) : base(number, balance, creditLine, owner)
        {

        }
        protected override double CalculInterets()
        {
            return  Balance*0.045;
        }
    }
}
