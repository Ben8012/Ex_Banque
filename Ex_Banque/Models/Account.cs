using Ex_Banque.Exceptions;
using Ex_Banque.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Models
{
    internal abstract class Account : IBanker , ICustomer
    {
       
        protected Account(string number, Person owner)
        {
            Number = number;
            Owner = owner;
        }

        protected Account(string number, decimal balance, decimal creditLine, Person owner)
        {
            Number = number;
            Balance = balance;
            CreditLine = creditLine;
            Owner = owner;
        }


        public string Number { get; private set; }
        public decimal Balance { get; private set; }


        private decimal _creditLine;
        public decimal CreditLine
        {
            get {  return _creditLine; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("la ligne de credit ne peut etre une valeur negative");
                }
                _creditLine = value;
            }
        }

       
        public Person Owner { get;  }
        public void Withdraw(decimal amount)
        {
            if (amount >= Balance + CreditLine) throw new InsufficientBalanceException("le montant doit etre inferieur au solde + la ligne de credit");
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("le montant doit etre superieur a 0");
            Balance += amount;
        }


        protected abstract decimal CalculInterets();

        public void ApplyInterest()
        {
            Balance += CalculInterets();
        }

    }
}
