using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class CityMap:ClassMap<City>
    {
        public CityMap()
        {
            Table("City");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Column("Name");
            Map(x => x.ParentId).Column("ParentId");
        }
    }
}
