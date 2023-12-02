using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Weapon
    {

        public EnumContainer.WeaponType WeaponType { get; set; }
        public int Damage { get; set; }
        public int FireRate { get; set; }
        public int Level { get; set; }
        public Weapon(EnumContainer.WeaponType weaponType, int damage, int fireRate, int level)
        {
            WeaponType = weaponType;
            Damage = damage;
            FireRate = fireRate;
            Level = level;
        }
    }
}
