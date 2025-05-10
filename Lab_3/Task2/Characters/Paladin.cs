using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters
{
    public class Paladin : ICharacter
    {
        public void ShowStats()
        {
            Console.WriteLine("Паладин: Сила 7, Мана 5, Захист 7");
        }
    }
}
