using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;

namespace MakonaApp
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
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
                    var products = await db.products
                        .Include(p => p.product_types)
                        .ToListAsync();
                    dgProducts.ItemsSource = products;
                }
            }
            catch (Exception ex)
            {
                dgProducts.ItemsSource = null;
            }
        }
    }
}