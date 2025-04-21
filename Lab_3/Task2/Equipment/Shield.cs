using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;

namespace Task2.Equipment
{
    public class Shield : CharacterDecorator
    {
        public Shield(ICharacter character) : base(character) { }

        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine(" + Щит: +3 до захисту");
        }
    }
}
