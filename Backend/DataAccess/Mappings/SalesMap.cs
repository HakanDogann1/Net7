using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class SalesMap:ClassMap<Sales>
    {
        public SalesMap()
        {
            Table("Sales");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Date).Column("Date");
            Map(x => x.Piece).Column("Piece");
            References(x=>x.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(x=>x.CustomerId).Column("CustomerId").Not.LazyLoad();
            References(x=>x.ProductId).Column("ProductId").Not.LazyLoad();
        }
    }
}
