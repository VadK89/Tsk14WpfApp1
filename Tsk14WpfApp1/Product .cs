using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk14WpfApp1
{
    public enum ProductTypes
    {
        Food,
        HouseTech
    }

    public class Product
    {
        public string ProductName { get; set; } 
        public int Price { get; set; }
        public string Image { get; set; }
        public int Category { get; set; }
        public ProductTypes ProductType { get; set; }


    }
}
