using Base.Db.Helper;
using Base.Db.Manager;
using DataAccess.Helpers;
using DataAccess.Interfaces;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class NHibernateAccountDal : RepositoryManager<Account>, IAccountDal
    {
        private readonly NHibernateHelper _helper;
        public NHibernateAccountDal(PostgresHelper postgresHelper) : base(postgresHelper)
        {
            _helper = postgresHelper;
        }
    }
}
