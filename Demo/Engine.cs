using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Engine
    {

        public EnumContainer.EngineType EngineType { get; set; }
        public int Speed { get; set; }
        public Engine(EnumContainer.EngineType engineType, int speed)
        {
            EngineType = engineType;
            Speed = speed;
        }

    }
}
