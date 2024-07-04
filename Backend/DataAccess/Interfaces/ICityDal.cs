,using Base.Db.Interface;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICityDal:IRepositoryService<City>
    {
        List<City> ParentById(int id,int skip,int take);
        void MultipleDelete(List<City> cities);
    }
}
