using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    public class Player
    {
        private string _name = "Robert";
        private int _health = 50;
        private int _power = 30;
        private int _maxHealth = 100;
        private int _maxPower = 100;
        public string name { get => _name; }
        public int health { get => _health; set => _health = value; }
        public int power { get => _power; set => _power = value; }
        public int maxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int maxPower { get => _maxPower; set => _maxPower = value; }
        public Player()
        {

        }
    }
}
