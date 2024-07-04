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
    public class SalesManager : ISalesService
    {
        private readonly ISalesDal _salesDal;

        public SalesManager(ISalesDal salesDal)
        {
            _salesDal = salesDal;
        }

        public Sales Add(Sales sales)
        {
            return _salesDal.Add(sales);
        }

        public void Delete(Sales sales)
        {
            _salesDal.Delete(sales);
        }

        public List<Sales> GetAll()
        {
           return _salesDal.GetList();
        }

        public Sales GetById(int id)
        {
            return _salesDal.Get(x=>x.Id == id);
        }

        public Sales Update(Sales sales)
        {
            return _salesDal.Update(sales);
        }
    }
}
