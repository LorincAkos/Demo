using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class BackgroundElements
    {
        public int x {  get; set; }
        public int y { get; set; }
        public Image bgElements { get; set; }

        public BackgroundElements() {
            x = RandomNumberGenerator.GenerateNumber(-50, -20);
            y = RandomNumberGenerator.GenerateNumber(20, 500);
            bgElements = Image.FromFile("Images\\FallingMeteor.gif");
        }
    }
}
