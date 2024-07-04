using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICityService
    {
        List<City> ParentById(int id, int skip, int take);
        void MultipleDelete(List<City> cities);
        List<City> GetAll();
        City GetById(int id);
        City Add(City City);
        City Update(City City);
        void Delete(City City);
    }
}
