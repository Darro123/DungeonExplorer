using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Testing
    {
        //creates a unique version of the player for the combat test
        public static Player testingPlayer { get; set; }

        public static Room room = new Room();
        public static bool _testing { get; set; }


        public static void testingDebug() 
        {
            Console.WriteLine("Welcome to the Testing Class what would you like to test today");
            Console.WriteLine("Input C for combat test, M for room test");
            _testing = true;

            var testingKey = Console.ReadKey().Key;
            // var _combat = Combat.CombatLinearInput();

            //simply pulls the next room description to verify its functionality
            if (testingKey == ConsoleKey.M)
            {
                Room.GetDescription();
            }
            //new player created with a set name and health to make the combat test functional and creates a combat instance with error checking
            else if (testingKey == ConsoleKey.C) 
            {
                var playerName = Player.GetPlayerName();
                testingPlayer = new Player(playerName, 100);

                Combat combat = new Combat();
                combat.StartCombat(testingPlayer);
            }
            else 
            {
                Console.WriteLine("Invalid input...");
                testingDebug();       
            }

        }

    }
}
