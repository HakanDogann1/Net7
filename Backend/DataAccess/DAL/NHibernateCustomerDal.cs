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
    public class NHibernateCustomerDal : RepositoryManager<Customer>, ICustomerDal
    {
        private readonly NHibernateHelper _helper;
        public NHibernateCustomerDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }
    }
}
