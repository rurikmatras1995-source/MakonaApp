using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MakonaApp
{
    public partial class CustomersPage : Page
    {
        public CustomersPage()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                using (var db = new МАКОНАEntities())
                {
                    var customers = await db.customers.ToListAsync();
                    dgCustomers.ItemsSource = customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                using (var db = new МАКОНАEntities())
                {
                    var searchText = tbSearch.Text.Trim();
                    var customers = await db.customers
                        .Where(c => c.last_name.Contains(searchText) ||
                                    c.first_name.Contains(searchText) ||
                                    c.phone.Contains(searchText))
                        .ToListAsync();
                    dgCustomers.ItemsSource = customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearSearch_Click(object sender, RoutedEventArgs e)
        {
            tbSearch.Text = "";
        }
    }
}