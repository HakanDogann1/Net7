﻿using Base.Db.Interface;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserAuthorityDal:IRepositoryService<UserAuthority>
    {
        List<Employee> GetByEmployees(int AuthorityId,int skip,int take);
    }
}
