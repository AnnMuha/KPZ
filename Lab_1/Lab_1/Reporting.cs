using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Reporting : IReporting
    {
        public void GenerateInventoryReport(IProductManager warehouse)
        {
            Console.WriteLine("Складський облік:");
            foreach (var product in warehouse.GetProducts())
            {
                Console.WriteLine(product);
            }
        }

        public void RegisterProductReceipt(IProductManager warehouse, string productName, int quantity, DateTime restockDate)
        {
            var product = warehouse.FindProduct(productName);
            if (product != null)
            {
                product.IncreaseStock(quantity, restockDate);
                Console.WriteLine($"Надходження: {quantity} {product.Unit} {productName} ({product.Category}) додано до складу");
            }
        }

        public void RegisterProductShipment(IProductManager warehouse, string productName, int quantity)
        {
            Product product = warehouse.FindProduct(productName);
            if (product != null)
            {
                if (product.Quantity >= quantity)
                {
                    product.DecreaseStock(quantity);
                    Console.WriteLine($"Відвантаження: {quantity} {product.Unit} {product.Name} ({product.Category}) відправлено зі складу");
                }
                else
                {
                    Console.WriteLine($"Помилка: Недостатньо {product.Name} на складі для відвантаження {quantity} {product.Unit}! Доступно лише {product.Quantity} {product.Unit}.");
                }
            }
            else
            {
                Console.WriteLine($"Помилка: Продукт {productName} не знайдено на складі!");
            }
        }
    }
}
