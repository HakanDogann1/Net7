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
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public City Add(City City)
        {
            return _cityDal.Add(City);
        }

        public void Delete(City City)
        {
            _cityDal.Delete(City);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetList();
        }

        public City GetById(int id)
        {
            return _cityDal.Get(x => x.Id == id);
        }

        public void MultipleDelete(List<City> cities)
        {
            _cityDal.MultipleDelete(cities);
        }

        public List<City> ParentById(int id, int skip, int take)
        {
            return _cityDal.ParentById(id, skip, take);
        }

        public City Update(City City)
        {
            return _cityDal.Update(City);
        }
    }
}
