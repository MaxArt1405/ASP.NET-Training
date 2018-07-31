using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.Interfaces
{
    public interface IAccountIdGenerator
    {
        int GenerateId(int lastId);
    }
}
