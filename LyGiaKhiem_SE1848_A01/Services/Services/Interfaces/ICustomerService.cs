using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer? GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        List<Customer> Search(string keyword);
    }
}
