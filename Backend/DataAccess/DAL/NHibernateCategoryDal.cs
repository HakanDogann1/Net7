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
    public class NHibernateCategoryDal : RepositoryManager<Category>, ICategoryDal
    {
        private readonly NHibernateHelper _helper;
        public NHibernateCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }

        public List<Category> Paging(int skip, int take)
        {
            using(var session = _helper.OpenSession())
            {
                var result = session.Query<Category>().OrderBy(x=>x.Name).Skip(skip).Take(take).ToList();
                return result;
            }
        }
    }
}
