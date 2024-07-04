using Base.Db.Helper;
using Base.Db.Interface;
using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.Db.Manager
{
    public class RepositoryManager<T> : IRepositoryService<T> where T : class, IEntity ,new()
    {
        private NHibernateHelper _NHibernateHelper;

        public RepositoryManager(NHibernateHelper nHibernateHelper)
        {
            _NHibernateHelper = nHibernateHelper;
        }

        public T Add(T entity)
        {
            using (var session = _NHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
            
        }

        public void Delete(T entity)
        {
            using (var session = _NHibernateHelper.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
                session.Clear();
            }
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            using (var session = _NHibernateHelper.OpenSession())
            {
                return session.Query<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var session = _NHibernateHelper.OpenSession())
            {
                return filter == null ? session.Query<T>().ToList():session.Query<T>().Where(filter).ToList();
            }
        }

        public T Update(T entity)
        {
            using (var session = _NHibernateHelper.OpenSession())
            {
                session.Update(entity);
                session.Flush();
                session.Clear();
                return entity;
            }
        }
    }
}
