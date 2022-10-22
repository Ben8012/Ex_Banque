using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Models
{
    internal abstract class Account 
    {
        protected Account(string number, double balance, double creditLine, Person owner)
        {
            Number = number;
            Balance = balance;
            CreditLine = creditLine;
            Owner = owner;
        }

        public string Number { get; set; }
        public double Balance { get; private set; }
        public double CreditLine { get; set; }
        public Person Owner { get; set; }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }


        protected abstract double CalculInterets();

        public void ApplyInterest()
        {
            Balance += CalculInterets();
        }


    }
}
