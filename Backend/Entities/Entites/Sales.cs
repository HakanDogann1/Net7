﻿using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    public class Sales : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Product ProductId { get; set; }
        public virtual Customer CustomerId { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int  Piece { get; set; }
        public virtual Employee EmployeeId { get; set; }
    }
}
