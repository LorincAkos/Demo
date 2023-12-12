using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Ammo
    {
        public  Image bullett {  get; set; }


        public int x {  get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        public Ammo(Image bullett)
        {
            this.bullett = bullett;
        }
    }
}
