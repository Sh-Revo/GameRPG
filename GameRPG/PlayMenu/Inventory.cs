using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.PlayMenu
{
    public class Inventory 
    {
        public List<Item> inventories;

        public Inventory()
        {
            inventories = new List<Item>();
        }
        
        public void AddInventory(Item item)
        {
            if (inventories.Count > 0)
            {
                for (int i = 0; i < inventories.Count; i++)
                {
                    if (item.Id == inventories[i].Id)
                    {
                        inventories[i].Count++;
                        break;
                    }
                    else if (i == inventories.Count - 1)
                    {
                        inventories.Add(item);
                        break;
                    }
                }
            }    
            else
            {
                inventories.Add(item);
            }
        }

        public void GetAll()
        {
            Console.WriteLine("Inventory: ");
            foreach (Item item in inventories)
            {
                Console.WriteLine($"Name: {item.Name}, Count: {item.Count}");
            }            
        }

        public void SellAll(Player player)
        {
            Console.WriteLine("\nSold!");
            foreach (Item item in inventories)
            {
                if (item.Name == "coin")
                {
                    player.money += item.Count;
                    item.Count = 0;
                    continue;
                }
                if (item.Name == "gem")
                {
                    player.money += item.Count * 5;
                    item.Count = 0;
                    continue;
                }
                player.money += item.Count;
                item.Count = 0;
            }

            inventories.Clear();
        }
    }
}
