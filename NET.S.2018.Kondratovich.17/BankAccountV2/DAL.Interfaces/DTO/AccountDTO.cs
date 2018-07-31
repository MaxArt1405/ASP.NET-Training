using BLL.Interfaces.Accounts.BaseAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.DTO
{
    public class AccountDTO
    {
        public string Id { get; set; }
        public string HolderName { get; set; }
        public decimal Balance { get; set; }
        public int BonusPoints { get; set; }
        public int Type { get; set; }
        public Status Status { get; set; }
    }
}
