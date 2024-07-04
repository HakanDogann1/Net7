using Base.Db.Helper;
using Base.Db.Manager;
using DataAccess.Interfaces;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class NHibernateUserAuthorityDal : RepositoryManager<UserAuthority>, IUserAuthorityDal
    {
        private readonly NHibernateHelper _helper;
        public NHibernateUserAuthorityDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }

        public List<Employee> GetByEmployees(int AuthorityId, int skip, int take)
        {
            using(var session = _helper.OpenSession())
            {
                var result = session.Query<UserAuthority>().Where(x=>x.AuthorityId.Id == AuthorityId)
                    .Select(x=>x.EmployeeId).Skip(skip).Take(take)
                    .ToList();
                return result;
            }
        }
    }
}
