using BLL.Interfaces.Accounts.BaseAccount;


namespace BLL.Interfaces.Interfaces
{
    public interface IBankAccountFactory
    {
        BankAccount Create(string id, string name, decimal balance, int bonusPoints, Status status, BankAccountTypes type);
    }
}
