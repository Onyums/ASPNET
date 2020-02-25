using ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProdcuts();

        public Product GetProduct(int id);

        public void UpdateProduct(Product product);

    }
}
