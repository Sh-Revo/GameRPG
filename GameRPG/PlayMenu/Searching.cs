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
        Inventory inventory;
        public void search(Player player)
        {
            int rand = random.Next(0, 100);

            if (player.power > 10)
            {
                player.power--;
                if (rand <= 5)
                {
                    Console.WriteLine("you found a chest\n");
                }
                else if (rand <= 10)
                {
                    Console.WriteLine("you found a gem\n");
                }
                else if (rand <= 20)
                {
                    Console.WriteLine("you found tree\n");
                }
                //else if (rand <= 30)
                //{
                //    if (rand == 21)
                //    {
                //        inventory.AddInventory(0, "rock", 1);
                //    }
                //}
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
