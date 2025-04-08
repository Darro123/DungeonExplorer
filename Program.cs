using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dungeon Explorer! Press any button to begin.");
            Console.WriteLine("");
            Console.ReadKey();

            // Initialize the game
            Game game = new Game();
          
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void EndProgram() 
        {
            // End of program
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
