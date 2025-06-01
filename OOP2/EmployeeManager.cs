using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class EmployeeManager
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void ShowAllData()
        {
            Employees.ForEach(e => Console.WriteLine(e));
        }
        public void UpdateEmployee(int id, string newName, string newIdCard, DateTime newBirthday)
        {
            Employee emp = Employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.Name = newName;
                emp.IdCard = newIdCard;
                emp.Birthday = newBirthday;
                Console.Write($"Đã cập nhật thông tin nhân viên ID = {id}");
            }
            else Console.Write($"Không tìm thấy nhân viên có ID = {id}");
        }
        public void DeleteEmployee(int id)
        {
            Employee emp = Employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                Employees.Remove(emp);
                Console.Write($"Đã xóa nhân viên ID = {id}");
            }
            else Console.Write($"Không tìm thấy nhân viên có ID = {id}");
        }
    }

}
