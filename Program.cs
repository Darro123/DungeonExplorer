using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        private Testing testingClass;
        public static Game game;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dungeon Explorer! Press any button to begin or, press T to open the testing menu.");
            Console.WriteLine("");

            var inputKey = Console.ReadKey().Key;
          
            if (inputKey == ConsoleKey.T)
            {
                Testing.testingDebug();          
            }
            else 
            {
                // Initialize the game

                game = new Game();
            }

          
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }


    }
}
