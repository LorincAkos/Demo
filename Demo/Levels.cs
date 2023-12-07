using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class Levels
    {
        public static int CurrentLevel { get; set; }
        public static int UnlockedLevel { get; set; }

        static Levels()
        {
            CurrentLevel = 1;
            UnlockedLevel = 10;
        }

        public static void GetLevelInfo(int currentlvl, out int enemyCount, out Image enemyImage, out Color background, out Image bgElement)
        {
            switch (currentlvl)
            {
                case 1:
                    enemyCount = 10;
                    background = Color.Black;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[0]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 2:
                    enemyCount = 15;
                    background = Color.Chocolate;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[1]);
                    enemyImage = Image.FromFile(ImageContainer.DropItemImage[0]);
                    break;
                case 3:
                    enemyCount = 20;
                    background = Color.DarkGray;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[0]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 4:
                    enemyCount = 25;
                    background = Color.PeachPuff;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[1]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 5:
                    enemyCount = 30;
                    background = Color.Violet;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[0]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 6:
                    enemyCount = 35;
                    background = Color.DarkOrchid;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[1]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 7:
                    enemyCount = 40;
                    background = Color.Black;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[0]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 8:
                    enemyCount = 45;
                    background = Color.Black;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[1]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 9:
                    enemyCount = 50;
                    background = Color.DarkBlue;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[0]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                case 10:
                    enemyCount = 1;
                    background = Color.Black;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[1]);
                    enemyImage = Image.FromFile(ImageContainer.EnemyImage[0]);
                    break;
                default:
                    enemyCount = 100;
                    background = Color.Black;
                    bgElement = Image.FromFile(ImageContainer.BackgroundElementImage[0]);
                    enemyImage = Image.FromFile(ImageContainer.DropItemImage[0]);
                    break;
                    
            }
        }
    }
}
