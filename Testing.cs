using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Testing
    {
        public static Player testingPlayer { get; set; }

        public static Room room = new Room();
        public static bool _testing { get; set; }


        public static void testingDebug() 
        {
            Console.WriteLine("Welcom to the Testing Class what would you like to test today");
            Console.WriteLine("Input C for combat test, M for room test");
            _testing = true;

            var testingKey = Console.ReadKey().Key;
            // var _combat = Combat.CombatLinearInput();

            if (testingKey == ConsoleKey.M)
            {
                room.GetDescription();
            }
            else if (testingKey == ConsoleKey.C) 
            {
                var playerName = Player.GetPlayerName();
                testingPlayer = new Player(playerName, 100);
            }

        }

    }
}
