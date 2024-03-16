using System;
using System.Security.Principal;



public class Program
{
    static  void Main(string[] args)
    {
        Account myAccount = new Account();
        myAccount._balance = 50;
        myAccount.Deposit(10);

        Console.WriteLine("Balance after deposit: $" + myAccount._balance);


    }
}

public class Account
{
    public int _balance = 0;
    public void Deposit(int amount)
    {
        _balance = _balance + amount;
    }
}
