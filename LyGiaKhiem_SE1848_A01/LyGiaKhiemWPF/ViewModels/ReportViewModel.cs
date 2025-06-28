using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using LyGiaKhiemWPF.Commands;
using Services.Services.Helpers;
using Services.Services.Interfaces;
using System.Windows.Input;

namespace LyGiaKhiemWPF.ViewModels
{
    public class ReportViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService = SingletonHelper.OrderService;

        public ObservableCollection<Order> Orders { get; set; } = new();
        public DateTime FromDate { get; set; } = DateTime.Today.AddDays(-7);
        public DateTime ToDate { get; set; } = DateTime.Today;

        public int OrderCount => Orders.Count;

        public ICommand GenerateReportCommand { get; }

        public ReportViewModel()
        {
            GenerateReportCommand = new RelayCommand(GenerateReport);
            // Tải báo cáo ban đầu khi ViewModel được khởi tạo
            GenerateReport();
        }

        private void GenerateReport()
        {
            var result = _orderService.GetByDateRange(FromDate, ToDate);
            Orders.Clear();
            if (result != null)
            {
                foreach (var order in result)
                    Orders.Add(order);
            }
            OnPropertyChanged(nameof(OrderCount));
        }
    }
}
