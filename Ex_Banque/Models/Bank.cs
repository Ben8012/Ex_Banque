using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banque.Models
{
    internal class Bank
    {
        public Bank(string name)
        {
            Name = name;
            //Accounts = new Dictionary<string, CurrentAccount>();
            Accounts = new ();
        }


        public readonly Dictionary<string, Account> Accounts;

        public string? Name { get; set; }

        public void AddAccount(Account account)
        {
            Accounts.Add(account.Number, account);
        }

        public void DeleteAccount(string number)
        {
            Accounts.Remove(number);
        }
    }
}
