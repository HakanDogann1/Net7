using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class CustomerMap:ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("Customer");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(x => x.CityId).Column("CityId").Not.LazyLoad();
            Map(x => x.Address).Column("Address");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
            Map(x => x.NameSurname).Column("NameSurname");
        }
    }
}
