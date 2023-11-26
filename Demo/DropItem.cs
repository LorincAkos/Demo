using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DropItem
    {

        public int x {  get; set; }
        public int y { get; set; }
        public Image Item { get; set; }
        public DropItem(int x, int y, Image item)
        {
            this.x = x;
            this.y = y;
            Item = item;
        }

    }
}
