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
    public class NHibernateProductDal : RepositoryManager<Product>, IProductDal
    {
        private readonly NHibernateHelper _helper;
        public NHibernateProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }

        public List<Product> GetCategoryById(int id, int skip, int take)
        {
            using(var session = _helper.OpenSession())
            {
                var result = session.Query<Product>().Where(x=>x.CategoryId.Id==id)
                    .OrderBy(x=>x.Name)
                    .Skip(skip).Take(take).ToList();
                return result;
            }
        }
    }
}
