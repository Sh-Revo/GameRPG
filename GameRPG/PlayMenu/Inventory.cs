using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.PlayMenu
{
    public class Inventory : IInventory
    {
        public static List<Item> inventories;
        

        public void AddInventory(Item item)
        {
            inventories.Add(item);
        }
    }
}
