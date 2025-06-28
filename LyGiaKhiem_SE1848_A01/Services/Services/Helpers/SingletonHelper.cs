using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Repositories.Implementations;
using Repositories.Repositories.Interfaces;
using Services.Services.Implementations;
using Services.Services.Interfaces;

namespace Services.Services.Helpers
{
    public static class SingletonHelper
    {
        public static readonly ICategoryService CategoryService = new CategoryService(new CategoryRepository());
        public static readonly ICustomerService CustomerService = new CustomerService(new CustomerRepository());
        public static readonly IEmployeeService EmployeeService = new EmployeeService(new EmployeeRepository());
        public static readonly IOrderService OrderService = new OrderService(new OrderRepository());
        public static readonly IOrderDetailService OrderDetailService = new OrderDetailService(new OrderDetailRepository());
        public static readonly IProductService ProductService = new ProductService(new ProductRepository());
    }
}
