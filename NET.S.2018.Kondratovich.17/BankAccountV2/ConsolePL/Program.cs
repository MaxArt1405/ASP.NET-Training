using BankAccount2._0.BusinessModel;
using BankAccount2._0.Factories;
using BankAccount2._0.Service;
using BLL.Interfaces.Accounts.BaseAccount;
using BLL.Interfaces.Exceptions;
using BLL.Interfaces.Interfaces;
using DAL.Repository;
using System;

namespace ConsolePL
{
    class Program
    {
        private int _id = 0;
        static void Main(string[] args)
        {
            while (Console.ReadLine() != "Exit")
            {
                try
                {
                    (new Program()).DoSomething();
                }
                catch (InsufficientOfMoneyException NotMoneyExp)
                {
                    Console.WriteLine(NotMoneyExp.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void DoSomething()
        {
            var repository = new BankAccountRepository();
            var bankService = new BankAccountService(repository);

            var account1 = CreateAccount();
            var account2 = CreateAccount();
            var account3 = CreateAccount();
            var account4 = CreateAccount();

            account1.Deposite(1700);
            account2.Deposite(1700);
            account3.Deposite(1700);
            account4.Deposite(1700);

            bankService.Add(account1);
            bankService.Add(account2);
            bankService.Add(account3);
            bankService.Add(account4);
            Console.WriteLine(bankService);

            account1.Withdraw(150);
            account2.Status = Status.Close;
            bankService.Remove(account3);
            
            Console.WriteLine(bankService);
        }
        private BankAccount CreateAccount()
        {
            var factory = new BankAccountFactory();
            Console.Write("The holder name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Type of the bank account :");
            string inputtype = Console.ReadLine();
            _id = new AccountIdGenerator().GenerateId(_id);
            Enum.TryParse(inputtype, true, out BankAccountTypes type);
            string state = "Open";
            Enum.TryParse(state, true, out Status status);




            BankAccount account = factory.Create(_id.ToString(), name, 0, 0, status, type);
            return account;
        }
    }
}
