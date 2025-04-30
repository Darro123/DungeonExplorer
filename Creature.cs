using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    abstract class Creature
    {
        //creates an overridable fucntion for the monster and player classes to call from
        public abstract void Attack(string currentWeapon = null);
    }
}
