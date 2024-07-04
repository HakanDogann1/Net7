using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class UserAuthorityMap:ClassMap<UserAuthority>
    {
        public UserAuthorityMap()
        {
            Table("UserAuthority");
            Id(x=>x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Password).Column("Password");
            References(p => p.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(p => p.AuthorityId).Column("AuthorityId").Not.LazyLoad();

        }
    }
}
