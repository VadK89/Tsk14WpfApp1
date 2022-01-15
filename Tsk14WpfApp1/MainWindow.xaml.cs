using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tsk14WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Утюг",
                Price = 3300,
                Image = "Data/iron.png",
                Category=1,
                ProductType = ProductTypes.HouseTech
            });           
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                Price = 39,
                Image = "Data/bread.png",
                Category = 2,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Фрукты",
                Price = 130,
                Image = "Data/fruits.png",
                Category = 2,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Холодильник",
                Price = 25000,
                Image = "Data/fridge.png",
                Category = 1,
                ProductType = ProductTypes.HouseTech
            });
            products.Add(new Product()
            {
                ProductName = "Овощи",
                Price = 130,
                Image = "Data/vegetables.png",
                Category = 2,
                ProductType = ProductTypes.Food
            });
            lstBox.ItemsSource = products;
        }

    }
}

