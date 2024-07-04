using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAuthorityService
    {
        List<Authority> GetAll();
        Authority GetById(int id);
        Authority Add(Authority Authority);
        Authority Update(Authority Authority);
        void Delete(Authority Authority);
    }
}
