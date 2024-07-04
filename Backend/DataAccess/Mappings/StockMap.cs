using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class StockMap:ClassMap<Stock>
    {
        public StockMap()
        {
            Table("Stock");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Date).Column("Date");
            Map(x => x.Piece).Column("Piece");
            References(x => x.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(x => x.ProductId).Column("ProductId").Not.LazyLoad();
        }
    }
}
