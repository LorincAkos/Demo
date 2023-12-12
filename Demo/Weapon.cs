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
        public Image bulletImage { get; set; }
        public Weapon(EnumContainer.WeaponType weaponType, int damage, int fireRate, int level)
        {
            WeaponType = weaponType;
            Damage = damage;
            FireRate = fireRate;
            Level = level;
            bulletImage = Image.FromFile("Images\\ammo1.png");
        }

        public void ChangeWeapon(string path)
        {
            switch (path)
            {
                case "Images\\Weapon1.png":
                    bulletImage = Image.FromFile("Images\\ammo1.png");
                    break;
                case "Images\\Weapon2.png":
                    bulletImage = Image.FromFile("Images\\ammo2.png");
                    break;
                case "Images\\Weapon3.png":
                    bulletImage = Image.FromFile("Images\\ammo3.png");
                    break;
                case "Images\\Weapon4.png":
                    bulletImage = Image.FromFile("Images\\ammo4.png");
                    break;
                default:
                    break;
            }
        }
    }
}
