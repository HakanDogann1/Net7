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
    public class AuthorityManager : IAuthorityService
    {
        private readonly IAuthorityDal _authorityDal;

        public AuthorityManager(IAuthorityDal authorityDal)
        {
            _authorityDal = authorityDal;
        }

        public Authority Add(Authority authority)
        {
            return _authorityDal.Add(authority);
        }

        public void Delete(Authority authority)
        {
            _authorityDal.Delete(authority);
        }

        public List<Authority> GetAll()
        {
            return _authorityDal.GetList();
        }

        public Authority GetById(int id)
        {
            return _authorityDal.Get(x=>x.Id==id);
        }

        public Authority Update(Authority Authority)
        {
            return _authorityDal.Update(Authority);
        }
    }
}
