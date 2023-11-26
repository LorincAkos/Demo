using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Player
    {
        public string Name { get; set; }
        public Ship Ship { get; set; }
        public Weapon Weapon { get; set; }
        public Engine Engine { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int SkillPoints { get; set; }
        public int Credit { get; set; }
        public int SpecialCredit { get; set; }
        public Player(string name, Ship ship, Weapon weapon, Engine engine, int level, int xp, int skillPoints, int credit, int specialCredit)
        {
            Name = name;
            Ship = ship;
            Weapon = weapon;
            Engine = engine;
            Level = level;
            Xp = xp;
            SkillPoints = skillPoints;
            Credit = credit;
            SpecialCredit = specialCredit;
        }

    }
}
