using BankAccounts.AccountBuilder;
using BankAccounts.Accounts.BaseAccount;
using BankAccounts.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadLine() != "exit")
                {
                    try
                {
                    (new Program()).DoSomething();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
        public void DoSomething()
        {
            var account = new BankAccountBuilder();
            var bankService = new BankAccountService();
            AddAccountsToService(bankService, account);
            Console.WriteLine(bankService.ToString());
        }
        public void AddAccountsToService(IBankAccountService bankService, BankAccountBuilder accountBuilder)
        {
            BankAccount account1 = accountBuilder.Create("Hiroshi Nakmura", 370000, 1000, Status.Close ,BankAccountTypes.Prime);
            BankAccount account2 = accountBuilder.Create("Ilon Mask", 2000000, 35000, Status.Open, BankAccountTypes.Silver);
            BankAccount account3 = accountBuilder.Create("Inkognito man", 22500, 1000, Status.Waiting, BankAccountTypes.Gold);
            BankAccount account4 = accountBuilder.Create("Kondratovich Maxim", 2555000, 58000, Status.Open, BankAccountTypes.Platinum);

            account1.Deposite(2500);
            account4.Deposite(5000);
            account2.Withdraw(1100);
            account3.Withdraw(2250);

            bankService.Add(account1);
            bankService.Add(account2);
            bankService.Add(account3);
            bankService.Add(account4);
            bankService.Deactivate(account1, Status.Waiting);
        }
    }
}
