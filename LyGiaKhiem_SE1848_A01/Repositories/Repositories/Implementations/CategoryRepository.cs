using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessObjects.DAO;
using Repositories.Repositories.Interfaces;

namespace Repositories.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetAll();
        public Category? GetById(int id) => CategoryDAO.GetById(id);
        public void Add(Category category) => CategoryDAO.Add(category);
        public void Update(Category category) => CategoryDAO.Update(category);
        public void Delete(int id) => CategoryDAO.Delete(id);
    }
}
