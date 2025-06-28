using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using System.Xml.Linq;

namespace DataAccessObjects.DAO
{
    public class CategoryDAO
    {
        private static List<Category> categoryList = new();

        static CategoryDAO()
        {
            categoryList.Add(new Category { CategoryID = 1, CategoryName = "Furniture", Description = "Home and office furniture" });
            categoryList.Add(new Category { CategoryID = 2, CategoryName = "Sports", Description = "Sporting goods and equipment" });
            categoryList.Add(new Category { CategoryID = 3, CategoryName = "Toys", Description = "Children's toys and games" });
            categoryList.Add(new Category { CategoryID = 4, CategoryName = "Groceries", Description = "Daily food and beverage items" });
            categoryList.Add(new Category { CategoryID = 5, CategoryName = "Health", Description = "Healthcare and wellness products" });
            categoryList.Add(new Category { CategoryID = 6, CategoryName = "Automotive", Description = "Car parts and accessories" });
            categoryList.Add(new Category { CategoryID = 7, CategoryName = "Music", Description = "Instruments and audio equipment" });
            categoryList.Add(new Category { CategoryID = 1, CategoryName = "Electronics", Description = "Devices and gadgets" });
            categoryList.Add(new Category { CategoryID = 2, CategoryName = "Books", Description = "Printed and digital books" });
            categoryList.Add(new Category { CategoryID = 3, CategoryName = "Clothes", Description = "Apparel and accessories" });
        }

        public static List<Category> GetAll() => categoryList;

        public static Category? GetById(int id) =>
            categoryList.FirstOrDefault(c => c.CategoryID == id);

        public static void Add(Category category)
        {
            category.CategoryID = categoryList.Any() ? categoryList.Max(c => c.CategoryID) + 1 : 1;
            categoryList.Add(category);
        }

        public static void Update(Category category)
        {
            var existing = GetById(category.CategoryID);
            if (existing != null)
            {
                existing.CategoryName = category.CategoryName;
                existing.Description = category.Description;
            }
        }

        public static void Delete(int id)
        {
            var category = GetById(id);
            if (category != null) categoryList.Remove(category);
        }
    }
}
