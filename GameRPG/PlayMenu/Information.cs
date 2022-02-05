using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.PlayMenu
{
    public class Information
    {
        public void GetInfo(Player player)
        {
            Console.WriteLine("Players name: " + player.name);
            Console.WriteLine("Players health: " + player.health);
            Console.WriteLine("Players power: " + player.power);
        }
    }
}

