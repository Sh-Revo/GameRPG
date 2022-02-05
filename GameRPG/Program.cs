using GameRPG.PlayMenu;
using System;

namespace GameRPG
{
    public class Program
    {
        static bool flag = true;
        static Player player;
        
        IHunting hunting = new Hunting();

        static void Main(string[] args)
        {
            player = new Player();
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
                    PlayMenu();
                    break;
            }
        }

        public static void PlayMenu()
        {
            Console.WriteLine("1: Get info");
            Console.WriteLine("2: Search");
            Console.WriteLine("3: Hunting");
            Console.WriteLine("0: Exit");

            ConsoleKey key = GetButton();
            Console.Clear();
            IInformation information = new Information();
            ISearching searching = new Searching();
            switch (key)
            {
                case ConsoleKey.D1:                   
                    information.GetInfo(player);
                    Console.WriteLine();
                    PlayMenu();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    searching.search(player);
                    PlayMenu();
                    break;
                case ConsoleKey.D3:
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
