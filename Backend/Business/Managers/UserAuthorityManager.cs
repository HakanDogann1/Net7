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
    public class UserAuthorityManager : IUserAuthorityService
    {
        private readonly IUserAuthorityDal _userAuthorityDal;

        public UserAuthorityManager(IUserAuthorityDal userAuthorityDal)
        {
            _userAuthorityDal = userAuthorityDal;
        }

        public UserAuthority Add(UserAuthority UserAuthority)
        {
            return _userAuthorityDal.Add(UserAuthority);
        }

        public void Delete(UserAuthority UserAuthority)
        {
            _userAuthorityDal.Delete(UserAuthority);
        }

        public List<UserAuthority> GetAll()
        {
            return _userAuthorityDal.GetList();
        }

        public List<Employee> GetByEmployees(int AuthorityId, int skip, int take)
        {
            return _userAuthorityDal.GetByEmployees(AuthorityId, skip, take);
        }

        public UserAuthority GetById(int id)
        {
            return _userAuthorityDal.Get(x=>x.Id == id);
        }

        public UserAuthority Update(UserAuthority UserAuthority)
        {
            return _userAuthorityDal.Update(UserAuthority);
        }
    }
}
