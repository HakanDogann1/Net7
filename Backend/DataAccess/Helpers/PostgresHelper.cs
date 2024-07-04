using Base.Db.Helper;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helpers
{
    public class PostgresHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            var build = Fluently.Configure()
                .Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(""))
                .Mappings(p=>p.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(TreatConfiguration).BuildSessionFactory();
            return build;
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true); //veritabanı yoksa oluştur anlamına gelir.
        }
    }
}
