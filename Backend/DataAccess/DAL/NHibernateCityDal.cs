using Base.Db.Helper;
using Base.Db.Manager;
using DataAccess.Interfaces;
using Entities.Entites;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class NHibernateCityDal : RepositoryManager<City>, ICityDal
    {
        private readonly NHibernateHelper _helper;
        public NHibernateCityDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _helper = nHibernateHelper;
        }

        public void MultipleDelete(List<City> cities)
        {
            using (var session = _helper.OpenSession())
            {
                foreach (var item in cities)
                {
                    session.Delete(item);
                }
                session.Flush();
                session.Close();
            }
            
        }

        public List<City> ParentById(int id, int skip, int take)
        {
           using (var session =  _helper.OpenSession())
            {
                var result = session.Query<City>().Where(x=>x.ParentId== id)
                    .OrderBy(x=>x.Name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();

                return result;
            }
        }
    }
}
