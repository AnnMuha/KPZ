using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;

namespace Task2.Equipment
{
    public class RingOfPower : CharacterDecorator
    {
        public RingOfPower(ICharacter character) : base(character) { }

        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine(" + Кільце Сили: +2 до мани, +2 до сили");
        }
    }
}
