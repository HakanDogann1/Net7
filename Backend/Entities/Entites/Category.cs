using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    public class Category:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
