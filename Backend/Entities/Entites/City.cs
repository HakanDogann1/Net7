using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    public class City:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int ParentId { get; set; }
    }
}
