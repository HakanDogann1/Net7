using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserAuthorityService
    {
        List<Employee> GetByEmployees(int AuthorityId, int skip, int take);
        List<UserAuthority> GetAll();
        UserAuthority GetById(int id);
        UserAuthority Add(UserAuthority UserAuthority);
        UserAuthority Update(UserAuthority UserAuthority);
        void Delete(UserAuthority UserAuthority);
    }
}
