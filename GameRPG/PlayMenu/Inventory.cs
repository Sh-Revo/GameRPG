using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.PlayMenu
{
    public class Inventory : IInventory
    {
        public List<Item> inventories;

        public Inventory()
        {
            inventories = new List<Item>();
        }
        
        public void AddInventory(Item item)
        {
            //if (item.Id == inventories.)
            inventories.Add(item);
        }

        public void GetAll()
        {
            Console.WriteLine("Items: ");
            foreach (Item item in inventories)
            {
                Console.WriteLine(item.Name);
            }
            
        }


    }
}
