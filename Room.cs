﻿using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Room
    {
        public static int currentRoom = -1;
            

        private readonly string _room1Description = "You enter a room dark and slightly damp. Cool air rushes in from behind you pushing life and energy into this otherwise desolet hole. 1 other entrance spans off into the dark and in the center is a small collection of scrap left here you assume when the mine was left to rot";
        private readonly string _room2Description = "Decending furthering down into the hole, the mine tunnel abruptly breaks into mossy and cracked stone brick moisture thickens the air of this now dungeon and you find yourself in a room mostly empty weapon racks line the walls and a center table dotted with small trinkets. Across from you a rotted wooden door sits quietley";
        private readonly string _room3Description = "With the wooden door creeping open, a large round room with a few dozen skeletons lay lifelessly across the stone floorwith small trinkets littering them. A large arch way rests open on the otherside";
        private readonly string _room4Description = "You progress through the arch way and the dugneon opens up into a collection of stone towers in a large cavern. It is clear to you now that your adventure is just beginning...";

        public static List<string> room1Items = new List<string> {"dagger"};
        public static List<string> room2Items = new List<string> { "sword", "20 copper coins" };
        public static List<string> room3Items = new List<string> { "shield", "30 gold coins" };

        public List<string> RoomDescriptions = new List<string>();
        public List<List<string>> RoomItems = new List<List<string>>();

        public Room()
        {
            RoomDescriptions.Add(_room1Description);
            RoomDescriptions.Add(_room2Description);
            RoomDescriptions.Add(_room3Description);
            RoomDescriptions.Add(_room4Description);

            RoomItems.Add(room1Items);
            RoomItems.Add(room2Items);
            RoomItems.Add(room3Items);
        }

        public string GetDescription()
        {
            currentRoom++;
            string roomDescription = RoomDescriptions[currentRoom];


            //Console.WriteLine(roomItems);
            Console.WriteLine(roomDescription);

            return roomDescription;


            //if (currentRoom <= 4) 
            //{
            //    Program.ClearConsole();
            //   Console.WriteLine("This is were the program ends, for now...");
            //    Program.EndProgram();
            //    return "";
            //}
            //else
            //{
            //    currentRoom++;
            //    string roomDescription = RoomDescriptions[currentRoom];


            //    //Console.WriteLine(roomItems);
            //    Console.WriteLine(roomDescription);

            //    return roomDescription;
            //}

        }

        public List<string> GetItems()
        {
            List<string> roomItems = RoomItems[currentRoom];
            return roomItems;
        }
    }
}