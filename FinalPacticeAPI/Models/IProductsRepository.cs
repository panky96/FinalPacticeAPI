using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPacticeAPI.Models
{
    public interface IProductsRepository
    {
        public IEnumerable<Products> GetAll();

        public Products GetById(int id);
    }
}
