using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal interface IProductManager
    {
        void AddProduct(Product product);
        void RemoveProduct(string productName, int quantity);
        Product FindProduct(string name);
        List<Product> GetProducts();
    }
}
