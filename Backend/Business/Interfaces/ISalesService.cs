using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISalesService
    {
        List<Sales> GetAll();
        Sales GetById(int id);
        Sales Add(Sales sales);
        Sales Update(Sales sales);
        void Delete(Sales sales);
    }
}
