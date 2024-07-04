using Base.Db.Helper;
using Base.Db.Manager;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class NHibernateEmployeeDal : RepositoryManager<Employee>
    {
        private readonly NHibernateHelper _helper;
        public NHibernateEmployeeDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }
    }
}
