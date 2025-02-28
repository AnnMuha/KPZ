using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Warehouse : IProductManager
    {
        private List<Product> productList = new List<Product>();

        public void AddProduct(Product product)
        {
            productList.Add(product);
            Console.WriteLine($"Продукт {product.Name} ({product.Category}) додано до складу.");
        }

        public void RemoveProduct(string productName, int quantity)
        {
            var product = productList.Find(p => p.Name == productName);
            if (product != null)
            {
                product.DecreaseStock(quantity);
            }
        }

        public Product FindProduct(string name)
        {
            return productList.Find(p => p.Name == name);
        }

        public List<Product> GetProducts()
        {
            return productList;
        }
    }
}
