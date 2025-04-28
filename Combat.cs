using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Combat
    {

        public Player currentPlayer;
        public Testing TestingClass; 
        public Game game;
        public Monster monster;

        public int currentMonsterHealth = 0;
        public int monsterHealthRemaining = 0;

        public Combat() 
        {
            monster = new Monster("Goblin!!!", 50);

            var monsterName = Monster.Name;
            int monsterHealth = Monster.Health;

            currentMonsterHealth = monsterHealth;

            // Establishes the Combat instance of the player if the user is activley testing or uses the Game.player instance if the user is activley playing the game.
            if (Testing._testing == true)
            {
                currentPlayer = Testing.testingPlayer;
                CombatLinearInput();
            }
            else if (Testing._testing == false) 
            { 
                currentPlayer = Game.player;
                CombatLinearInput();          
            }
            
        }

        public void CombatLinearInput()
        {
            //Checks if Testing is true, as in the code two instance of the player are managed differntly
            //The player created to make the combat test function and the player created in the game class. These if statments ensure there are no conflicts!
            if (Testing._testing == true) 
            {
                Console.WriteLine($"Entering the room you are greeted with a {Monster.Name}. It pulls out a club, what is your move {Player.Name}");
                Console.WriteLine("Press A to attack, E see equiped weapon");
                PlayerCombatLoop();
            }
            else if (Testing._testing == false) 
            {

                Console.WriteLine($"Entering the room you are greeted with a {Monster.Name}. It pulls out a club, what is your move {Player.Name}");
                Console.WriteLine("Press A to attack, E see equiped weapon");
                PlayerCombatLoop();
            }

        }


        //The primary combat function, allows the player to attack and check their equipped weapon 
        public void PlayerCombatLoop()
        {
            var CombatInputKey = Console.ReadKey().Key;

            //if (Player.Health >= 0) 
            //{
            //    Console.WriteLine("Your health has reached 0! Your journey unfortunatly ends here...");          
            //}

            //if (Monster.Health >= 0) 
            //{
            //    Console.WriteLine("Your foe has been defeated!");
            //    game.PlayerInput();
            //}

            if (CombatInputKey == ConsoleKey.E)
            {
                var C_inputInv = Inventory.equipedItem;
                Console.WriteLine($"You have equiped {C_inputInv}");
            }
            else if (CombatInputKey == ConsoleKey.A) 
            {
                currentPlayer.Attack();
                monster.Attack();
                PlayerCombatLoop();
            }
            else
            {
                Console.WriteLine("Invalid input, Try Again!");
                PlayerCombatLoop();
            }
        }

        public int DamageMonster(int damage) 
        {
            currentMonsterHealth -= damage;

            return currentMonsterHealth;
        }







    }

}
