using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class Player
    {
        public static string Name { get; set; }
        public static Ship Ship { get; set; }
        public static Weapon Weapon { get; set; }
        public static Engine Engine { get; set; }
        public static int Level { get; set; }
        public static int Xp { get; set; }
        public static int SkillPoints { get; set; }
        public static int Credit { get; set; }
        public static int SpecialCredit { get; set; }

        public static int x { get; set; }
        public static int y { get; set; }

        static Player()
        {
            Name = "Pity";
            Ship = new Ship(0, 0, 0, 3, 1, 0, 1);
            Weapon = new Weapon(0, 1, 1, 1);
            Engine = new Engine(0, 1);
            Level = 1;
            Xp = 0;
            SkillPoints = 0;
            Credit = 100;
            SpecialCredit = 0;
            x = 300;
            y = 500;
        }
        

    }
}
