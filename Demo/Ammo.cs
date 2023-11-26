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
        public static Image bullett = Image.FromFile(@"C:\Users\Desktop\source\repos\Demo\Demo\Images\ammo1.png");
        public int x {  get; set; }
        public int y { get; set; }
        public int speed { get; set; }
    }
}
