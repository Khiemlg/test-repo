using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using Repositories.Repositories.Interfaces;
using Services.Services.Interfaces;

namespace Services.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public List<Employee> GetEmployees() => _repo.GetEmployees();
        public Employee? GetById(int id) => _repo.GetById(id);
        public Employee? GetByUsername(string username) => _repo.GetByUsername(username);
        public void Add(Employee employee) => _repo.Add(employee);
        public void Update(Employee employee) => _repo.Update(employee);
        public void Delete(int id) => _repo.Delete(id);
        public bool ValidateLogin(string username, string password) => _repo.ValidateLogin(username, password);
    }
}
