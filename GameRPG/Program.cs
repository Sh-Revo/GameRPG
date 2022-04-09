using GameRPG.PlayMenu;
using System;
using System.Collections.Generic;

namespace GameRPG
{
    public class Program
    {
        static bool flag = true;
        static Player player;
        static Inventory inventory;
        static List<Item> inventories;

        static void Main(string[] args)
        {
            player = new Player();
            inventory = new Inventory();
            inventories = new List<Item>();
            FirstMenu();


        }

        public static void FirstMenu()
        {
            Console.WriteLine("1: play");
            Console.WriteLine("0: exit");

            ConsoleKey key = GetButton();
            Console.Clear();

            switch (key)
            {
                case ConsoleKey.D1:
                    PlayMenu();
                    break;
                case ConsoleKey.D0:
                    break;
                default:
                    Console.WriteLine("Wrong command 1");
                    FirstMenu();
                    break;
            }
        }

        public static void PlayMenu()
        {
            Console.WriteLine("1: Get info");
            Console.WriteLine("2: Search");
            Console.WriteLine("3: Hunting");
            Console.WriteLine("4: Inventory");
            Console.WriteLine("0: Exit");

            ConsoleKey key = GetButton();
            Console.Clear();
            Information information = new Information();
            Searching searching = new Searching();

            switch (key)
            {
                case ConsoleKey.D1:                   
                    information.GetInfo(player);
                    Console.WriteLine();
                    PlayMenu();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    searching.search(player, inventory);
                    PlayMenu();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    PlayMenu();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine();
                    inventory.GetAll();
                    Console.WriteLine("5: Sell");
                    Console.WriteLine("Or Use Another button to continue");
                    key = GetButton();
                    if (key == ConsoleKey.D5)
                    {
                        Console.Clear();
                        inventory.SellAll(player);
                    } 
                    else
                    {
                        Console.Clear();
                    }
                    Console.WriteLine();
                    PlayMenu();
                    break;
                case ConsoleKey.D0:                   
                    break;
                default:
                    Console.WriteLine("Wrong command 2");
                    PlayMenu();
                    break;
            } 
        }

        public static ConsoleKey GetButton()
        {
            var key = Console.ReadKey().Key;

            return key;
        }
    }
}
