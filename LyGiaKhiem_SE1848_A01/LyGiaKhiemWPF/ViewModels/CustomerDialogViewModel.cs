using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace LyGiaKhiemWPF.ViewModels
{
    public class CustomerDialogViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        public CustomerDialogViewModel()
        {
            Customer = new Customer();
        }

        public CustomerDialogViewModel(Customer original)
        {
            // Tạo một bản sao để tránh chỉnh sửa trực tiếp đối tượng gốc
            Customer = new Customer
            {
                CustomerID = original.CustomerID,
                CompanyName = original.CompanyName,
                ContactName = original.ContactName,
                ContactTitle = original.ContactTitle,
                Address = original.Address,
                Phone = original.Phone
            };
        }
    }
}
