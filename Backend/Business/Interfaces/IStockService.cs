using Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IStockService
    {
        List<Stock> GetAll();
        Stock GetById(int id);
        Stock Add(Stock stock);
        Stock Update(Stock stock);
        void Delete(Stock stock);
    }
}
