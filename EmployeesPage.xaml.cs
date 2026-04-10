using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;

namespace MakonaApp
{
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
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
                    var employees = await db.employees.ToListAsync();
                    dgEmployees.ItemsSource = employees;
                }
            }
            catch (Exception ex)
            {
                dgEmployees.ItemsSource = null;
            }
        }
    }
}