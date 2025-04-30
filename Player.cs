using System;
using System.Collections.Generic;
using System.Data;
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
        }

        //servers as the player attack script ovverided from the creature class
        public override void Attack(string currentWeapon = null)
        {
            //sets the player attack dice as the equivelent as a 10 sided dice
            DamageDealt = randomD10.Next(1, 11);

            //access the percentage increase from the item subclass and creating a number that is the percentage amount of the damage dealt increasing it by its set value
            int modifiedDamageDealt = (DamageDealt * Items.GetDamageModifier(currentWeapon) / 100);
            //adds both damage dealt and the damage added by the weapon mod
            int totalDamageDealt = DamageDealt + modifiedDamageDealt;

            //calls and sets the monster health 
            int monsterHealthRemaining = Combat.DamageMonster(totalDamageDealt);

            //main dialouge for the combat, prints the eqquiped weapon, total dmaage dealt, damage added by the mod and the remain enemy health
            Console.WriteLine($"\nWeapon Equipped = {Inventory.equipedItem}");
            Console.WriteLine($"You dealt {totalDamageDealt} Damage!"); 
            Console.WriteLine($"With you modified weapon you deal an extra {modifiedDamageDealt}");
            Console.WriteLine($"The Enemy has {monsterHealthRemaining} health left!");

            //checks at the end of each player attack if the monster health is 0 or below, it then wires them back into the player input option in game
            if (monsterHealthRemaining <= 0)
            {
                Program.ClearConsole();
                Console.WriteLine($"You've Won! The Monster had {monsterHealthRemaining} Remaining.\n");
                Game.PlayerInput();
            }

        }

        //ges the player name and detects if there is any white space or the name is empty if it is, it asks the user to input a new user name and returns the created name
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

    }

   
}