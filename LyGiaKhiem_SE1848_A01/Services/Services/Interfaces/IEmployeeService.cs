using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee? GetById(int id);
        Employee? GetByUsername(string username);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        bool ValidateLogin(string username, string password);
    }
}
