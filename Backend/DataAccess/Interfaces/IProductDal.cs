using Base.Db.Interface;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IProductDal:IRepositoryService<Product>
    {
        public List<Product> GetCategoryById(int id,int skip,int take);

    }
}
