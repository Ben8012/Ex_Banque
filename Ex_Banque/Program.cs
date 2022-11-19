using Ex_Banque.Models;
using System.Security.Principal;

List<Person> listPerson = new List<Person>();
List<Account> listAccount = new List<Account>();
List<Bank> listBank = new List<Bank>();

for (int i = 0; i < 10; i++)
{
    Random random = new Random();
    int rand = random.Next(1,100);
    listPerson.Add( new Person($"firstname {i+1}", $"lastname {i+1}",DateTime.Now));
}

for (int i = 0; i < 10; i++)
{
    listAccount.Add(new CurrentAccount($"100{i}", 100, 100, listPerson[i]));
    listAccount.Add(new Saving($"200{i}", 0
        , 100, listPerson[i]));
}
for (int i = 0; i < 2; i++)
{
    listBank.Add(new Bank($"bank {i+1}"));
}

for (int i = 0; i < listBank.Count; i++)
{
    if(i == 0)
    {
        for (int j = 0; j < listAccount.Count - listAccount.Count/2; j++)
        {
            listBank[i].AddAccount(listAccount[j]);
        }
    }
    if (i == 1)
    {
        for (int j = listAccount.Count/2; j < listAccount.Count; j++)
        {
            listBank[i].AddAccount(listAccount[j]);
        }
    }


}

// gestion du visuel dans la console
Console.WriteLine($"il y a {listBank.Count} banque{(listBank.Count > 1 ? "s" : "")} dans notre liste ");
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine($"Valeur de depart des {listAccount.Count} comptes de toutes les banques");
Console.WriteLine("----------------------------------");
AfficherComptes();
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("J'ajoute une valeur aleatoire comprise entre 1 et 5000 sur tout les comptes de toutes les banques et j'applique les interets");
Console.WriteLine("----------------------------------");
foreach (Bank bank in listBank)
{
    foreach (KeyValuePair<string,Account> account in bank.Accounts)
    {
        Random random = new Random();
        int rand = random.Next(1, 5000);
        account.Value.Deposit(rand);
        account.Value.ApplyInterest();
       
    }

}
AfficherComptes();
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("J'enleve une valeur aleatoire comprise entre 1 et 5000 sur un compte sur deux de toutes les banques");
Console.WriteLine("----------------------------------");
foreach (Bank bank in listBank)
{
    int i = 0;
    foreach (KeyValuePair<string, Account> account in bank.Accounts)
    {
        Random random = new Random();
        int rand = random.Next(1, 5000);
        if (i % 2 == 0) account.Value.Withdraw(rand);
        i++;
    }

}
AfficherComptes();
Console.WriteLine();
void AfficherComptes()
{   
    foreach (Bank bank in listBank)
    {
        Console.WriteLine($"{bank.Name} => ");
        foreach (KeyValuePair<string, Account> account in bank.Accounts)
        {
            Console.WriteLine($" Numero : {account.Key}, Propritetaire : {account.Value.Owner.LastName}, Solde : {account.Value.Balance} $");
        }
    }

}