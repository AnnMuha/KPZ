using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters
{
    public class Warrior : ICharacter
    {
        public void ShowStats()
        {
            Console.WriteLine("Воїн: Сила 10, Мана 2, Захист 5");
        }
    }
}
