using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition1.Entities
{
    internal class Product
    {
        public Product()
        {
        }

        public  string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
