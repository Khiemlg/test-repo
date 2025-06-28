using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Repositories.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product? GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> Search(string keyword);
    }
}
