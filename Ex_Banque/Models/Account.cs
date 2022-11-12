using Ex_Banque.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Models
{
    internal abstract class Account : IBanker , ICustomer
    {
        protected Account(string number, double balance, double creditLine, Person owner)
        {
            Number = number;
            _balance = balance;
            CreditLine = creditLine;
            Owner = owner;
        }

        private double _balance;

        public string Number { get; set; }
        public double Balance { get => _balance;  }
        public double CreditLine { get; set; }
        public Person Owner { get;  }
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }


        protected abstract double CalculInterets();

        public void ApplyInterest()
        {
            _balance += CalculInterets();
        }

       
    }
}
