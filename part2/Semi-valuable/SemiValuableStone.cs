using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class SemiValuableStone : Stone
    {
        public SemiValuableStone(string name, int price, double weight, int vis, int count) :
            base(name, price, weight, vis, count)
        {
            Type = "Semi-valuable stone";
        }

    }
}
