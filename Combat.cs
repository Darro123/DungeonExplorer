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
        public static Game game;
        public Monster monster;

        public static int currentMonsterHealth = 1;
        public int monsterHealthRemaining = 0;
        public static int currentPlayerHealth = 1;
        public int currentPlayerHealthRemaining = 0;


        public Combat() 
        {
            monster = new Monster("Goblin!!!", 50);

            var monsterName = Monster.Name;
            int monsterHealth = Monster.Health;

            currentMonsterHealth = monsterHealth;

            // Establishes the Combat instance of the player if the user is activley testing or uses the Game.player instance if the user is activley playing the game.
            
        }

        public void StartCombat(Player player)
        {
            //if (Testing._testing == true)
            //{
            //    currentPlayer = Testing.testingPlayer;
            //    CombatLinearInput();
            //}
            //else if (Testing._testing == false)
            //{
            //    currentPlayer = Game.player;
            //    CombatLinearInput();
            //}

            currentPlayer = player;
            currentPlayerHealth = Player.Health;
            CombatLinearInput();

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


        //The primary combat function, allows the player to attack and equip a weapon and add a modifier  
        public void PlayerCombatLoop()
        {
            var CombatInputKey = Console.ReadKey().Key;


            var C_inputInv = Inventory.equipedItem;

            if (CombatInputKey == ConsoleKey.E)
            {
                
                if (Testing._testing == true)
                {
                    Program.ClearConsole();

                    //prints all avaible modifers and weapons and includes error checking for invalid inputs
                    Console.WriteLine("Weapons and Modifiers available:");

                    List<string> itemNames = new List<string>();

                    for (int i = 0; i < Items.Allitems.Count; i++)
                    {
                        itemNames.Add(Items.Allitems[i][0]);
                    }

                    Console.WriteLine(string.Join(", ", itemNames));
                    Console.WriteLine("\nType the name of the item to equip...\n");

                    void equip(bool incorrect = false)
                    {
                        if (incorrect)
                        {
                            Console.WriteLine("\nIncorrect input. Try again.\n");
                        }

                        var playerInput = Console.ReadLine();

                        //checks if the player input is a valid input then adds it to the Testing players inventory and allows them to attack
                        if (playerInput != null && !(Inventory.inventory.Contains(playerInput)))
                        {
                            Inventory.AddToIventory(playerInput);

                            Console.WriteLine("\nItem has been added to inventory and equipped.\n\n(A) to attack\n");

                            Inventory.equipedItem = playerInput;

                            PlayerCombatLoop();
                        }
                        else
                        {
                            equip(true);
                        }
                    }
                    
                    equip();
                }
            }
            else if (CombatInputKey == ConsoleKey.A)
            {
                //a very basic turn by turn player combat system. Opens with a player attack and weapon parameter then after a player input calls the monsters turn till one or the other is dead
                currentPlayer.Attack(C_inputInv);
                Console.WriteLine("\nNext turn\n\nPress any key");
                Console.ReadKey();
                Program.ClearConsole();
                monster.Attack();
                PlayerCombatLoop();
            }
            else
            {
                Console.WriteLine("Invalid input, Try Again!");
                PlayerCombatLoop();
            }


        }

        //sets the monster health to be used in the attack scripts
        public static int DamageMonster(int damage) 
        {
            currentMonsterHealth -= damage;

            return currentMonsterHealth;
        }

        //sets the player health to be used in the attack scripts
        public static int DamagePlayer(int Monsterdamage) 
        {
            currentPlayerHealth -= Monsterdamage;

            return currentPlayerHealth;  
        }





    }

}
