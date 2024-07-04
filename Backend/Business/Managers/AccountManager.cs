using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public Account Add(Account Account)
        {
            return _accountDal.Add(Account);
        }

        public void Delete(Account Account)
        {
            _accountDal.Delete(Account);
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetList();
        }

        public Account GetById(int id)
        {
            return _accountDal.Get(x=>x.Id == id);
        }

        public Account Update(Account Account)
        {
            return _accountDal.Update(Account);
        }
    }
}
