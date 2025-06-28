using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace LyGiaKhiemWPF.ViewModels
{
    public class EmployeeDialogViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }

        public EmployeeDialogViewModel()
        {
            Employee = new Employee();
        }

        public EmployeeDialogViewModel(Employee original)
        {
            Employee = new Employee
            {
                EmployeeID = original.EmployeeID,
                Name = original.Name,
                UserName = original.UserName,
                Password = original.Password,
                JobTitle = original.JobTitle
            };
        }
    }
}
