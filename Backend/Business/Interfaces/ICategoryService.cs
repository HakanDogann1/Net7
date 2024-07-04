using Base.Db.Interface;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> Paging(int skip, int take);
        Category GetById(int id);
        Category Add(Category category);
        Category Update(Category category);
        void Delete(Category category);
    }
}
