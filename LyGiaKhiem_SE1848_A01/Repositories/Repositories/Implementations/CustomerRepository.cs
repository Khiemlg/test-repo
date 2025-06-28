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
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers() => CustomerDAO.GetAll();
        public Customer? GetById(int id) => CustomerDAO.GetById(id);
        public void Add(Customer customer) => CustomerDAO.Add(customer);
        public void Update(Customer customer) => CustomerDAO.Update(customer);
        public void Delete(int id) => CustomerDAO.Delete(id);
        public List<Customer> Search(string keyword) => CustomerDAO.Search(keyword);
    }
}
