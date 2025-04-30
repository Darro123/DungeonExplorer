using System;
using System.Collections.Generic;


namespace DungeonExplorer
{
    class Game
    {
        public static Player player;
        public static Room room = new Room();
        private static Inventory inventory = new Inventory();
        private static Combat combat;
        // bool playing = false;

        public Game()
        {
            var playerName = Player.GetPlayerName();


            player = new Player(playerName, 100);
            Start();
        }
        public void Start()
        {
            Console.WriteLine($"\nYour chosen name is now: {Player.Name}");
            Console.WriteLine("You have " + Player.Health + " health points.");
            Console.WriteLine("You can move to the next room and make desicions when prompted\n");

            Program.ClearConsole();

            Console.WriteLine("You, " + Player.Name + " begin your adventure facing down an a dark open mineshaft. A cool breeze washes over you as you try to peer into the darkness. It was an exhausting 3 day hike here and you're not turning back now. You take a deep breath and step into the darkness.");
            Console.WriteLine("Press any key to continue...\n");

            Console.ReadKey();
            bool playing = true;
            // Console.WriteLine("playing = true");

            Program.ClearConsole();

            MoveToNextRoom();

            void MoveToNextRoom()
            {
                string roomDescription = Room.GetDescription();
                PlayerInput();
            }
        }
            
            


            public static void PlayerInput()
            {
                Console.WriteLine("What do you wish to do?.");
                Console.WriteLine(Player.Health + " health points.");
                Console.WriteLine("Press Q for control scheme");

                Console.WriteLine("");

                var playerKey = Console.ReadKey().Key;

                Program.ClearConsole();

                if (playerKey == ConsoleKey.C)
                {
                    // Check the room for items
                    List<string> roomItems = Room.GetItems();

                    Console.WriteLine(string.Join(", ", roomItems));
                    Console.WriteLine("Input the item you wish to interact with...");

                    var inputItem = Console.ReadLine();

                    if (roomItems.Contains(inputItem.ToLower()))
                    {
                        Console.WriteLine($"You have picked up {inputItem}");
                        Inventory.PickUpItem(inputItem);
                    }

                    PlayerInput();

                }
                else if (playerKey == ConsoleKey.I)
                {
                    // Write the player's inventory
                    Inventory.InventoryContents();

                    // Console.WriteLine(player.InventoryContents());
                    PlayerInput();
                }
                else if (playerKey == ConsoleKey.F)
                {
                    // Move to the next room
                    Console.WriteLine("You move to the next room");
                    Room.GetDescription();
                    PlayerInput();
                    //currentRoom = 2;
                }

                else if (playerKey == ConsoleKey.Q)
                {

                    Console.WriteLine("Press (C) to check the room for items");
                    Console.WriteLine("Press (I) to check your inventory");
                    Console.WriteLine("Press (F) to move to the next room");
                    PlayerInput();
                }
                else if (playerKey == ConsoleKey.A) 
                {

                    Combat combat = new Combat();
                    combat.StartCombat(player);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    PlayerInput();
                }
            }
            
        
    }
}