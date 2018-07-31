using BLL.Interfaces.Interfaces;

namespace BankAccount2._0.BusinessModel
{
    public class AccountIdGenerator : IAccountIdGenerator
    {
        public int GenerateId(int Id)
        {
            Id++;
            return Id;
        }
    }
}
