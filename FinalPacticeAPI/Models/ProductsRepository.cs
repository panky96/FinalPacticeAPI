using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPacticeAPI.Models
{
    public class ProductsRepository : IProductsRepository
    {
        private static List<Products> Products = new List<Products>();
        private int NextId = 1;
        public ProductsRepository()
        {
            #region List Of Products 
            Products.Add(new Products() {
                Id = NextId++,
                Name = "Iphone 12",
                Manufacturer = "Apple",
                Price = "$999"
            });
            Products.Add(new Products()
            {
                Id = NextId++,
                Name = "Iphone 12 mini",
                Manufacturer = "Apple",
                Price = "$699"
            });
            Products.Add(new Products()
            {
                Id = NextId++,
                Name = "Iphone 12 Pro",
                Manufacturer = "Apple",
                Price = "$1199"
            });
            #endregion

        }
        public IEnumerable<Products> GetAll()
        {
            return Products;
        }

        public Products GetById(int id)
        {
            return Products.FirstOrDefault( p => p.Id == id);
        }
    }
}
