using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;

namespace Task2.Equipment
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter character;

        public CharacterDecorator(ICharacter character)
        {
            this.character = character;
        }

        public virtual void ShowStats()
        {
            character.ShowStats();
        }
    }
}
