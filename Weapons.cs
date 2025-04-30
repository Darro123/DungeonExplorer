using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Weapons : Items
    {
        private static string[] dagger = new string[]
        {
            "dagger",
            "25" // Percentage of damage added onto an attack
        };
        
        private static string[] sword = new string[]
        {
            "sword",
            "50" // Percentage of damage added onto an attack
        };

        public Weapons() 
        {
            Items.Allitems.Add(dagger);
            Items.Allitems.Add(sword);
        }
    }
}
