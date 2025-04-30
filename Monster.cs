using System;
using System.Collections.Generic;
using System.Data;
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

        public static Combat combat;
        public Random randomD8 = new Random();
        public int MonsterDamageDealt = 0;
        public bool attacked = false;

        public Monster(string name, int health)
        {
            Name = name;
            Health = health;
        }


        // The script called from the linear combat loop that represents the monster attack
        public override void Attack(string currentWeapon = null)
        {
            //sets the damage dice for the monster being the equivelant of an 8 sided dice
            MonsterDamageDealt = randomD8.Next(1, 9);

            //Call the current player health from the Combat class and sets it as the current player health
            int currentPlayerHealth = Combat.DamagePlayer(MonsterDamageDealt);


            //prints the damge the monster did and preints the new player health
            Program.ClearConsole();
            Console.WriteLine($"You took {MonsterDamageDealt} Damage!");
            Console.WriteLine($"You have {currentPlayerHealth} health left!");

            //ends the program if the player health reaches 0 or less
             if (currentPlayerHealth <= 0)
             {
                    Program.ClearConsole();
                    Console.WriteLine($"Your current health has reached {currentPlayerHealth} your journey ends here\n");
                    Console.ReadKey();
             }

            



        }
    }
}
