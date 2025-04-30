using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    //Items class will manage the items in the game, including adding and removing items
    internal class Items
    {
        public static List<string[]> Allitems = new List<string[]>();

        //goes into the weapon and specifically calls the modifiers for each weapon
        public static int GetDamageModifier(string item)
        {
            for (int i = 0; i < Allitems.Count; i++)
            {
                if (Allitems[i][0] == item)
                {
                    return int.Parse(Allitems[i][1]);
                }
            }

            return 1;
        }
    }
}
