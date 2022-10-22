using Ex_Banque.Models;

List<Person> listPerson = new List<Person>();
List<CurrentAccount> listCurrentAccount = new List<CurrentAccount>();
List<Bank> listBank = new List<Bank>();

for (int i = 0; i < 10; i++)
{
    Random random = new Random();
    int rand = random.Next(1,100);
    listPerson.Add( new Person($"firstname {rand}", $"lastname {rand}",DateTime.Now));
}

for (int i = 0; i < 10; i++)
{
    listCurrentAccount.Add(new CurrentAccount($"100{i}", 100, 100, listPerson[i]));
}
for (int i = 0; i < 2; i++)
{
    listBank.Add(new Bank($"bank {i+1} => "));
}

for (int i = 0; i < listBank.Count; i++)
{
    if(i == 0)
    {
        for (int j = 0; j < listCurrentAccount.Count - listCurrentAccount.Count/2; j++)
        {
            listBank[i].AddAccount(listCurrentAccount[j]);
        }
    }
    if (i == 1)
    {
        for (int j = listCurrentAccount.Count/2; j < listCurrentAccount.Count; j++)
        {
            listBank[i].AddAccount(listCurrentAccount[j]);
        }
    }


}

foreach (Bank bank in listBank)
{
    Console.WriteLine(bank.Name);
    foreach (KeyValuePair<string,Account> account in bank.Accounts)
    {
        Random random = new Random();
        int rand = random.Next(1, 5000);
        account.Value.Deposit(rand);
        Console.WriteLine($" le compte numero : {account.Key} appartient a  {account.Value.Owner.FirstName} {account.Value.Owner.LastName} => solde = {account.Value.Balance} $");
    }
}


