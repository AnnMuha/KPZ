using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters
{
    public class Mage : ICharacter
    {
        public void ShowStats()
        {
            Console.WriteLine("Маг: Сила 3, Мана 10, Захист 2");
        }
    }
}
