using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public interface IBuilder
    {
        IBuilder SetHeight(int height);
        IBuilder SetBodyType(string bodyType);
        IBuilder SetHairColor(string hairColor);
        IBuilder SetEyeColor(string eyeColor);
        IBuilder SetOutfit(string outfit);
        IBuilder AddInventoryItem(string item);
        IBuilder AddGoodDeed(string deed);
        IBuilder AddEvilDeed(string deed);
        Character Build();
    }
}
