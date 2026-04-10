using System.Windows;

namespace MakonaApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new CustomersPage());
            StatusText.Text = "✅ Загружена страница заказчиков";
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CustomersPage());
            StatusText.Text = "👥 Показаны заказчики";
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
            StatusText.Text = "🔧 Показана продукция";
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
            StatusText.Text = "📦 Показаны заказы";
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmployeesPage());
            StatusText.Text = "👷 Показаны сотрудники";
        }
    }
}