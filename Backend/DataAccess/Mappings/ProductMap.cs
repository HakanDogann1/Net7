using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(x=>x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Column("Name");
            Map(x => x.Date).Column("Date");
            Map(x => x.Price).Column("Price");
            References(x => x.CategoryId).Column("CategoryId").Not.LazyLoad();
        }
    }
}
