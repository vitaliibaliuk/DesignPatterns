using lab2.task5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task5
{
    public class Creates
    {
        public Hero ConstructHero(IHeroBuilder builder)
        {
            return builder.SetHeight("Average")
        .SetBuild("Athletic")
        .SetHairColor("Brown")
        .SetEyeColor("Brown")
        .SetClothing("Cloak")
        .SetInventory("Sword, Shield")
        .Build();
        }

        public Hero ConstructEnemy(IHeroBuilder builder)
        {
            return builder.SetHeight("Average")
        .SetBuild("Thin")
        .SetHairColor("Blonde")
        .SetEyeColor("Grey")
        .SetClothing("Robe")
        .SetInventory("Staff, Tome")
        .Build();
        }
    }
}
