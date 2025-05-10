using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class HeroBuilder : IBuilder
    {
        private Character _character = new Character();

        public IBuilder SetHeight(int height)
        {
            _character.Height = height;
            return this;
        }

        public IBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public IBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public IBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public IBuilder SetOutfit(string outfit)
        {
            _character.Outfit = outfit;
            return this;
        }

        public IBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public IBuilder AddGoodDeed(string deed)
        {
            _character.GoodDeeds.Add(deed);
            return this;
        }

        public IBuilder AddEvilDeed(string deed)
        {
            return this; // Герой не робить зла
        }

        public Character Build()
        {
            return _character;
        }
    }
}
