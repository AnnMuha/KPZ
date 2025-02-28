using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Product
    {
        public string Name { get; private set; }
        public string Unit { get; private set; }
        public Money Price { get; private set; }
        public int Quantity { get; private set; }
        public DateTime LastRestockDate { get; private set; }
        public string Category { get; private set; }

        public Product(string name, string unit, Money price, int quantity, DateTime lastRestockDate, string category)
        {
            Name = name;
            Unit = unit;
            Price = price;
            Quantity = quantity;
            LastRestockDate = lastRestockDate;
            Category = category;
        }

        public void AdjustPrice(int major, int minor)
        {
            int totalMinorUnits = Price.MajorUnit * 100 + Price.MinorUnit;
            int adjustment = major * 100 + minor;
            totalMinorUnits = Math.Max(0, totalMinorUnits - adjustment);
            Price = new Money(totalMinorUnits / 100, totalMinorUnits % 100, Price.Currency);
        }

        public void IncreaseStock(int amount, DateTime restockDate)
        {
            Quantity += amount;
            LastRestockDate = restockDate;
        }

        public void DecreaseStock(int amount)
        {
            if (Quantity >= amount)
            {
                Quantity -= amount;
            }
            else
            {
                Console.WriteLine($"Помилка: Недостатньо {Name} на складі для відвантаження {amount} {Unit}!");
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Unit}, {Category}): {Price}, Кількість: {Quantity}, Останнє постачання: {LastRestockDate.ToShortDateString()}";
        }
    }

}

