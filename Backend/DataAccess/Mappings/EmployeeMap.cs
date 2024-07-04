using Entities.Entites;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("Employee");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Address).Column("Address");
            Map(x => x.Email).Column("Email");
            Map(x => x.NameSurname).Column("NameSurname");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
        }
    }
}
