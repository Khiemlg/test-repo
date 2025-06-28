using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using LyGiaKhiemWPF.Commands;
using Services.Services.Helpers;
using Services.Services.Interfaces;
using System.Windows.Input;
using System.Windows;

namespace LyGiaKhiemWPF.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        private readonly ICustomerService _customerService = SingletonHelper.CustomerService;

        public ICommand SaveCommand { get; }

        public ProfileViewModel()
        {
            // Load current customer info by ID
            Customer = _customerService.GetById(AppContext.CurrentCustomerID) ?? new Customer();
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            _customerService.Update(Customer);
            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
