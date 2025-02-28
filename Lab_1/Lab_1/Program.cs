using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Lab1
    {
        public class Program
        {
            public static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Warehouse warehouse = new Warehouse();
                Reporting reporting = new Reporting();

                Product apples = new Product("Яблуко", "кг", new Money(7, 50, "UAH"), 50, DateTime.Now, "Фрукти");
                Product potatoes = new Product("Картопля", "кг", new Money(15, 00, "UAH"), 25, DateTime.Now, "Овочі");
                warehouse.AddProduct(apples);
                warehouse.AddProduct(potatoes);

                Console.WriteLine("Початковий стан складу:");
                reporting.GenerateInventoryReport(warehouse);
                Console.WriteLine();

                apples.AdjustPrice(1, 20);
                potatoes.AdjustPrice(3, 50);
                Console.WriteLine("Після зниження цін:");
                reporting.GenerateInventoryReport(warehouse);
                Console.WriteLine();

                reporting.RegisterProductReceipt(warehouse, "Яблуко", 50, DateTime.Now);
                Console.WriteLine();

                reporting.RegisterProductShipment(warehouse, "Картопля", 20);
                Console.WriteLine();

                reporting.RegisterProductShipment(warehouse, "Картопля", 10);
                Console.WriteLine();

                reporting.RegisterProductReceipt(warehouse, "Банан", 30, DateTime.Now);
                warehouse.AddProduct(new Product("Банан", "кг", new Money(20, 00, "UAH"), 30, DateTime.Now, "Фрукти"));
                Console.WriteLine();

                Console.WriteLine("Після надходження та відвантаження товарів:");
                reporting.GenerateInventoryReport(warehouse);
            }
        }
    }
}
