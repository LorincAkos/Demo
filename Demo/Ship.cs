using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Ship
    {
        public EnumContainer.ShipType Id { get; set; }
        public EnumContainer.SkinType SkinType { get; set; }
        public EnumContainer.ChromaType ChromaType { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int Speed { get; set; }
        public Ship(EnumContainer.ShipType id, EnumContainer.SkinType skinType, EnumContainer.ChromaType chromaType, int hp, int level, int xp, int speed)
        {
            Id = id;
            SkinType = skinType;
            ChromaType = chromaType;
            Hp = hp;
            Level = level;
            Xp = xp;
            Speed = speed;
        }

    }
}
