﻿using System;
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
