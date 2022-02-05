using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.PlayMenu
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; } 
       
        public Item(int Id, string name, int count)
        {
            this.Id = Id;
            this.Name = name;
            this.Count = count;
        }

        public Item(string name)
        {
            this.Name = name;
        }
    }
}
