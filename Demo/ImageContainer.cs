using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class ImageContainer
    {
        public static List<string> BackgroundElementImage = new()
        { 
            @"C:\\Users\\Desktop\\source\\repos\\Demo\\Demo\\Images\\Comet.gif",
            @"C:\Users\Desktop\source\repos\Demo\Demo\Images\FallingMeteor.gif",
        };
        public static List<string> ShipImage = new()
        { 
            @"C:\Users\Desktop\source\repos\Demo\Demo\Images\SpaceShipStand.gif",
            @"C:\Users\Desktop\source\repos\Demo\Demo\Images\player.png",
        };
        public static List<string> SkinImage = new() { };
        public static List<string> WeaponImage = new() { };
        public static List<string> EngineImage = new() { };
        public static List<string> EnemyImage = new()
        {
            @"C:\\Users\\Desktop\\source\\repos\\Demo\\Demo\\Images\\E1.gif",
        };
        public static List<string> BossImage = new() { };
        public static List<string> DropItemImage = new()
        {
            @"C:\\Users\\Desktop\\source\\repos\\Demo\\Demo\\Images\\CommonGem.png",
            @"C:\\Users\\Desktop\\source\\repos\\Demo\\Demo\\Images\\UncommonGem.png",
            @"C:\Users\Desktop\source\repos\Demo\Demo\Images\RareGem.png",
            @"C:\Users\Desktop\source\repos\Demo\Demo\Images\LegendaryGem.png",
        };


    }
}
