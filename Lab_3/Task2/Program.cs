using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;
using Task2.Equipment;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== RPG Гра ===\n");

            ICharacter hero = new Warrior();
            Console.WriteLine("Базовий герой:");
            hero.ShowStats();

            Console.WriteLine("\nГерой з мечем:");
            hero = new Sword(hero);
            hero.ShowStats();

            Console.WriteLine("\nГерой з мечем і щитом:");
            hero = new Shield(hero);
            hero.ShowStats();

            Console.WriteLine("\nГерой з усім інвентарем:");
            hero = new RingOfPower(hero);
            hero.ShowStats();
        }
    }
}
