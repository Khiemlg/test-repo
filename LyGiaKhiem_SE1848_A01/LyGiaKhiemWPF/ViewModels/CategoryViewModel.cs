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
using System.Windows;
using LyGiaKhiemWPF.Views;

namespace LyGiaKhiemWPF.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        private readonly ICategoryService _categoryService = SingletonHelper.CategoryService;

        public ObservableCollection<Category> Categories { get; set; } = new();
        public Category? SelectedCategory { get; set; }

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public CategoryViewModel()
        {
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            DeleteCommand = new RelayCommand(Delete);
            LoadCategories();
        }

        private void LoadCategories()
        {
            Categories.Clear();
            foreach (var c in _categoryService.GetCategories())
                Categories.Add(c);
        }

        private void Add()
        {
            var vm = new CategoryDialogViewModel();
            var dialog = new CategoryDialog { DataContext = vm };
            if (dialog.ShowDialog() == true)
            {
                _categoryService.Add(vm.Category);
                LoadCategories();
            }
        }

        private void Edit()
        {
            if (SelectedCategory == null)
            {
                MessageBox.Show("Please select a category to edit.", "No Category Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var vm = new CategoryDialogViewModel(SelectedCategory);
            var dialog = new CategoryDialog { DataContext = vm };
            if (dialog.ShowDialog() == true)
            {
                _categoryService.Update(vm.Category);
                LoadCategories();
            }
        }

        private void Delete()
        {
            if (SelectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete.", "No Category Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete category '{SelectedCategory.CategoryName}'?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _categoryService.Delete(SelectedCategory.CategoryID);
                LoadCategories();
            }
        }
    }
}
