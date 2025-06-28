using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace LyGiaKhiemWPF.ViewModels
{
    public class CategoryDialogViewModel : BaseViewModel
    {
        public Category Category { get; set; }

        public CategoryDialogViewModel()
        {
            Category = new Category();
        }

        public CategoryDialogViewModel(Category original)
        {
            // Tạo một bản sao để tránh chỉnh sửa trực tiếp đối tượng gốc
            Category = new Category
            {
                CategoryID = original.CategoryID,
                CategoryName = original.CategoryName,
                Description = original.Description
            };
        }
    }
}
