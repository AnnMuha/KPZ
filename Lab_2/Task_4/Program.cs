using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Створюємо вірусне сімейство
            Virus originalVirus = new Virus("Вірус-Оригінал", 20, 5, "Alpha");
            originalVirus.AddChild(new Virus("Дитина 1", 10, 2, "Alpha"));
            originalVirus.AddChild(new Virus("Дитина 2", 8, 1, "Alpha"));

            var childVirus = new Virus("Онук", 5, 1, "Alpha");
            originalVirus.Offspring[0].AddChild(childVirus);

            // Клонуємо вірус разом із усіма дітьми та "онуками"
            Virus clonedVirus = (Virus)originalVirus.DeepClone();

            // Виводимо оригінал
            Console.WriteLine("Оригінальний вірус:");
            originalVirus.DisplayInfo();

            // Виводимо клон
            Console.WriteLine("\nСклонований вірус:");
            clonedVirus.DisplayInfo();
        }
    }
}
