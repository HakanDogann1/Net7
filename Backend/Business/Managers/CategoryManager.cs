using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p=>p.Id==id);
        }

        public List<Category> Paging(int skip, int take)
        {
            return _categoryDal.Paging(skip, take);
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }
    }
}
