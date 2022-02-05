using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.PlayMenu
{
    public class Searching : ISearching
    {
        Random random = new Random();
        public Inventory inventory;

        public Searching()
        {
            inventory = new Inventory();
        }

        public void search(Player player)
        {
            int rand = random.Next(0, 100);

            if (player.power > 10)
            {
                player.power--;
                if (rand <= 5)
                {
                    Console.WriteLine("you found a coin\n");
                    inventory.AddInventory(new Item(0, "coin", 1));
                }
                else if (rand <= 10)
                {
                    Console.WriteLine("you found a gem\n");
                    inventory.AddInventory(new Item(1, "gem", 1));
                }
                else if (rand <= 20)
                {
                    Console.WriteLine("you found stick\n");
                    inventory.AddInventory(new Item(2, "stick", 1));
                }
                else if (rand <= 30)
                {
                    if (rand <= 24)
                    {
                        Console.WriteLine("you found rock\n");
                        inventory.AddInventory(new Item(3, "rock", 1));
                    } 
                    else if (rand <= 28)
                    {
                        Console.WriteLine("you found pants\n");
                        inventory.AddInventory(new Item(4, "pants", 1));
                    }
                    else if (rand <= 30)
                    {
                        Console.WriteLine("you found hat\n");
                        inventory.AddInventory(new Item(5, "hat", 1));
                    }
                }
                else
                {
                    Console.WriteLine("you found nothing\n");
                }
            } 
            else
            {
                Console.WriteLine("the player is tired\n");
            }
        }
    }
}
