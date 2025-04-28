using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DungeonExplorer
{
     class Player : Creature
    {
        public static string Name { get; private set; }
        public static int Health { get; set; }
        public static Combat combat;
        
        public Random randomD10 = new Random();
        public int DamageDealt = 0;
        public bool attacked = false;

        // public var playerInventory = InventoryContents();

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;

            combat = new Combat();
        }

        public override void Attack()
        {
            DamageDealt = randomD10.Next(1, 11);
            
            int monsterHealthRemaining = combat.DamageMonster(DamageDealt);

            if (attacked == false)
            {

                Program.ClearConsole();
                Console.WriteLine($"You dealt {DamageDealt} Damage!"); // returns random integers >= 1 and < 10
                Console.WriteLine($"The Enemy has {monsterHealthRemaining} health left!");
                attacked = true;
            }

            else if (attacked == true)
            {

                Console.WriteLine($"You dealt {DamageDealt} Damage!");
                Console.WriteLine(monsterHealthRemaining);
            }


        }

        public static string GetPlayerName()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter your name: ");
            var inputName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputName))
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a valid name");
                return GetPlayerName();
            }
            else
            {
                return inputName;
            }

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

   
}