using System;
using System.Collections.Generic;

namespace Demo
{
    public static class ImageContainer
    {
        public static List<string> BackgroundElementImage = new()
        { 
            "Images\\Comet.gif",
            "Images\\FallingMeteor.gif",
        };
        public static List<string> ShipImage = new()
        { 
            "Images\\SpaceShipStand.gif",
            "Images\\player.png",
        };
        public static List<string> SkinImage = new() { };
        public static List<string> WeaponImage = new() { };
        public static List<string> EngineImage = new() { };
        public static List<string> EnemyImage = new()
        {
            "Images\\E1.gif",
        };
        public static List<string> BossImage = new() { };
        public static List<string> DropItemImage = new()
        {
            "Images\\CommonGem.png",
            "Images\\UncommonGem.png",
            "Images\\RareGem.png",
            "Images\\LegendaryGem.png",
        };


    }
}
