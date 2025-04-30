using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class WeaponModifiers : Items
    {
        private static string[] sharpened = new string[]
        {
            "sharpened",
            "10" // Percentage of damage added onto an attack
        };

        private static string[] heavy = new string[]
        {
            "heavy",
            "5" // Percentage of damage added onto an attack
        };

        public WeaponModifiers()
        {
            Items.Allitems.Add(sharpened);
            Items.Allitems.Add(heavy);
        }
    }
}
