using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAccountService
    {
        List<Account> GetAll();
        Account GetById(int id);
        Account Add(Account Account);
        Account Update(Account Account);
        void Delete(Account Account);
    }
}
