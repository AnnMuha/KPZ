using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class CharacterDirector
    {
        private IBuilder _builder;

        public CharacterDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public Character BuildHero()
        {
            return _builder.SetHeight(175)
                           .SetBodyType("Міцний")
                           .SetHairColor("Світле")
                           .SetEyeColor("Блакитні")
                           .SetOutfit("Лицарські обладунки")
                           .AddInventoryItem("Щит")
                           .AddInventoryItem("Меч")
                           .AddGoodDeed("Врятував село")
                           .Build();
        }

        public Character BuildEnemy()
        {
            return _builder.SetHeight(190)
                           .SetBodyType("Громила")
                           .SetHairColor("Чорне")
                           .SetEyeColor("Червоні")
                           .SetOutfit("Темний плащ")
                           .AddInventoryItem("Посох")
                           .AddEvilDeed("Спалив ліс")
                           .Build();
        }
    }
}
