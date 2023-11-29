using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Game : Form
    {

        Player player;

        List<BackgroundElements> BgElement;
        List<Enemy> enemy;
        List<Ammo> bullet;

        public Game()
        {
            InitializeComponent();


            enemy = new List<Enemy>();
            player = new Player("Pity", new Ship(0, 0, 0, 3, 1, 0, 1), new Weapon(0, 1, 1, 1), new Engine(0, 1), 1, 0, 0, 0, 0);
            BgElement = new List<BackgroundElements>();
            bullet = new();

            AmmoGeneration();
            Spawn();
            GenerateBG();
            GameStart();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Spawn()
        {
            for (int i = 0; i < 10; i++)
            {
                Enemy fill = new((i + 1) * 50);
                enemy.Add(fill);
            }

            for (int i = 0; i < enemy.Count; i++)
            {
                ImageAnimator.Animate(enemy[i].enemy, this.Animator);
            }
        }

        private void AmmoGeneration()
        {

            for (int i = 0; i < 1; i++)
            {
                Ammo b = new();
                bullet.Add(b);
            }
        }

        private void GenerateBG()
        {

            for (int i = 0; i < 5; i++)
            {
                BackgroundElements me = new BackgroundElements();
                BgElement.Add(me);
            }

            for (int i = 0; i < BgElement.Count; i++)
            {
                ImageAnimator.Animate(BgElement[i].bgElements, this.Animator);
            }

        }

        private void Animator(object? sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            Graphics Met = e.Graphics;
            Graphics Com = e.Graphics;
            Graphics Play = e.Graphics;
            Graphics En = e.Graphics;
            Graphics Am = e.Graphics;

            for (int i = 0; i < BgElement.Count; i++)
            {
                Met.DrawImage(BgElement[i].bgElements, BgElement[i].x, BgElement[i].y, 64, 64);
            }

            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i].X < 500)
                {
                    En.DrawImage(enemy[i].enemy, enemy[i].X, enemy[i].Y, 64, 64);
                }
            }

            for (int i = 0; i < bullet.Count; i++)
            {
                Am.DrawImage(Ammo.bullett, bullet[i].x, bullet[i].y, 16, 16);
            }

            Play.DrawImage(Image.FromFile(ImageContainer.ShipImage[Convert.ToInt32(player.Ship.Id)]), player.x, player.y, 32, 32);
        }

        private void BG_Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < BgElement.Count; i++)
            {
                BgElement[i].y += 7;

                if (BgElement[i].y > 600)
                {
                    BgElement[i].y = RandomNumberGenerator.GenerateNumber(-50, -20);
                    BgElement[i].x = RandomNumberGenerator.GenerateNumber(20, 500);
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                Player_Right_Timer.Start();
            }
            if (e.KeyCode == Keys.A)
            {
                Player_Left_Timer.Start();
            }
            if (e.KeyCode == Keys.W)
            {
                Player_Up_Timer.Start();
            }
            if (e.KeyCode == Keys.S)
            {
                Player_Down_Timer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                Ammo_Move_Timer.Start();
            }
        }

        private void Player_Left_Timer_Tick_1(object sender, EventArgs e)
        {
            if (player.x > 0)
            {
                player.x -= 5;
            }
        }

        private void Player_Right_Timer_Tick_1(object sender, EventArgs e)
        {
            if (player.x < 500)
            {
                player.x += 5;
            }
        }

        private void Player_Up_Timer_Tick_1(object sender, EventArgs e)
        {
            if (player.y > 0)
            {
                player.y -= 5;
            }
        }

        private void Player_Down_Timer_Tick_1(object sender, EventArgs e)
        {
            if (player.y < 500)
            {
                player.y += 5;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            Player_Right_Timer.Stop();
            Player_Left_Timer.Stop();
            Player_Up_Timer.Stop();
            Player_Down_Timer.Stop();
        }

        private void Enemy_Move_Timer_Tick_1(object sender, EventArgs e)
        {
            MoveEnemies();
        }

        private void MoveEnemies()
        {
            for (int i = 0; i < enemy.Count; i++)
            {
                enemy[i].Y += 1;

                if (enemy[i].Y > 550)
                {
                    enemy[i].X = (i + 1) * 50;
                    enemy[i].Y = -50;
                }
            }
        }

        private void Hit_Timer_Tick(object sender, EventArgs e)
        {
            HitEvent();
        }

        private void HitEvent()
        {
            for (int i = 0; i < enemy.Count; i++)
            {
                for (int j = 0; j < bullet.Count; j++)
                {
                    if (bullet[j].x >= enemy[i].X && bullet[j].y >= enemy[i].Y && bullet[j].x < enemy[i].X + 64 && bullet[j].y < enemy[i].Y + 64)
                    {
                        bullet[j].y = -200;
                        enemy[i].X = RandomNumberGenerator.GenerateNumber(0, 500);
                        enemy[i].Y = -75;
                    }
                }


                if (player.x >= enemy[i].X && player.y >= enemy[i].Y && player.x < enemy[i].X + 32 && player.y < enemy[i].Y + 32)
                {
                    enemy[i].X = RandomNumberGenerator.GenerateNumber(0, 500);
                    enemy[i].Y = -30;
                    player.Ship.Hp -= 1;
                    if (player.Ship.Hp == 0)
                    {
                        Close();
                    }
                }
            }
        }

        private void Ammo_Move_Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullet.Count; i++)
            {
                if (bullet[i].y > -100)
                {
                    bullet[i].y -= 20;
                }
                else
                {
                    bullet[i].x = player.x + 9;
                    bullet[i].y = player.y;
                }
            }
        }

        private void GameStart()
        {
            BG_Timer.Start();
            Enemy_Move_Timer.Start();
            Hit_Timer.Start();
        }


    }
}
