using BankAccounts.AccountBuilder;
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
        public void AddAccountsToService(IBankAccountService bankService, IBankAccountBuilder accountBuilder)
        {
            BankAccount account1 = accountBuilder.Create(1, "Hiroshi Nakmura", 370000, 1000, BankAccountTypes.Prime);
            BankAccount account2 = accountBuilder.Create(2, "Ilon Mask", 2000000, 35000, BankAccountTypes.Silver);
            BankAccount account3 = accountBuilder.Create(3, "Inkognito man", 22500, 1000, BankAccountTypes.Gold);
            BankAccount account4 = accountBuilder.Create(4, "Kondratovich Maxim", 2555000, 58000, BankAccountTypes.Platinum);

            account1.IncludeMoney(2500);
            account4.IncludeMoney(5000);
            account2.ExcludeMoney(1100);
            account3.ExcludeMoney(2250);

            bankService.Add(account1);
            bankService.Add(account2);
            bankService.Add(account3);
            bankService.Add(account4);
        }
    }
}
