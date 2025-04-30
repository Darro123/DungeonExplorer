using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    //Inventory class will manage the players inventory, including adding and removing items
    internal class Inventory
    {
        public static List<string> inventory = new List<string>();
        public static string equipedItem = "N/A";

        public static void InventoryContents()
        {
            Console.WriteLine($"You have the following items in your inventory: {string.Join(", ", inventory)}");
            Console.WriteLine("Write the item name to equip...");

            var inputInv = Console.ReadLine();

            if (inventory.Contains(inputInv.ToLower()))
            {
                Console.WriteLine($"You have equipped {inputInv}");
                //Console.WriteLine(ItemDes);
                //string equipedItem = inputInv;

                equipedItem = inputInv;
            }

   

        }

        public static void AddToIventory(string item) 
        {
            inventory.Add(item);
        }


        public static void PickUpItem(string item)
        {
            inventory.Add(item);
        }
    }
}
