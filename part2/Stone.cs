using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    public abstract class Stone
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public double Weight { get; set; }
        public int Vis { get; set; }
        public int Count { get; set; }

        public Stone(string name, int price, double weight,int vis,int count)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Vis = vis;
            Count = Count;
        }


    }
}
