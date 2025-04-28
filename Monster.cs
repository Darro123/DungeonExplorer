using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer

//Monster class must pull basic features like name, health, and attack from the creature class


{
    class Monster : Creature
    {
        public static string Name { get; private set; }
        public static int Health { get; private set; }

        public Monster(string name, int health)
        {
            Name = name;
            Health = health;
        }


        public override void Attack()
        {
                Console.WriteLine("Monster attack successful");
                
        }
    }
}
