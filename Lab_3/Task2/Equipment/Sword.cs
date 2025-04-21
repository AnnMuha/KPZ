using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;

namespace Task2.Equipment
{
    public class Sword : CharacterDecorator
    {
        public Sword(ICharacter character) : base(character) { }

        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine(" + Меч: +5 до сили");
        }
    }
}
