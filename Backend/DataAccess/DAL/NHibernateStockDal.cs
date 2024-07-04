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
    public class NHibernateStockDal : RepositoryManager<Stock>, IStockDal
    {
        private readonly NHibernateHelper _NHibernateHelper;
        public NHibernateStockDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _NHibernateHelper = nHibernateHelper;
        }
    }
}
