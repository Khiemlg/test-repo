using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using System.Xml.Linq;

namespace DataAccessObjects.DAO
{
    public class ProductDAO
    {
        private static List<Product> productList = new();

        static ProductDAO()
        {
            productList.Add(new Product { ProductID = 1, ProductName = "Office Desk", CategoryID = 1, UnitPrice = 250.00M, UnitsInStock = 40 });
            productList.Add(new Product { ProductID = 2, ProductName = "Mountain Bike", CategoryID = 2, UnitPrice = 750.00M, UnitsInStock = 25 });
            productList.Add(new Product { ProductID = 3, ProductName = "Lego Classic Set", CategoryID = 3, UnitPrice = 60.00M, UnitsInStock = 150 });
            productList.Add(new Product { ProductID = 4, ProductName = "Organic Rice 5kg", CategoryID = 4, UnitPrice = 10.00M, UnitsInStock = 500 });
            productList.Add(new Product { ProductID = 5, ProductName = "Vitamins C 1000mg", CategoryID = 5, UnitPrice = 12.00M, UnitsInStock = 200 });
            productList.Add(new Product { ProductID = 6, ProductName = "Car Engine Oil", CategoryID = 6, UnitPrice = 35.00M, UnitsInStock = 100 });
            productList.Add(new Product { ProductID = 7, ProductName = "Acoustic Guitar", CategoryID = 7, UnitPrice = 180.00M, UnitsInStock = 60 });
        }

        public static List<Product> GetAll() => productList;

        public static Product? GetById(int id) =>
            productList.FirstOrDefault(p => p.ProductID == id);

        public static void Add(Product product)
        {
            product.ProductID = productList.Any() ? productList.Max(p => p.ProductID) + 1 : 1;
            productList.Add(product);
        }

        public static void Update(Product product)
        {
            var existing = GetById(product.ProductID);
            if (existing != null)
            {
                existing.ProductName = product.ProductName;
                existing.CategoryID = product.CategoryID;
                existing.UnitPrice = product.UnitPrice;
                existing.UnitsInStock = product.UnitsInStock;
            }
        }

        public static void Delete(int id)
        {
            var product = GetById(id);
            if (product != null) productList.Remove(product);
        }

        public static List<Product> Search(string keyword) =>
            productList.Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
