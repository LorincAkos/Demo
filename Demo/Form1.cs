using System;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Demo
{
    public partial class Form1 : Form
    {
        Image Title;
        Image SrtImg;
        Image ExitImg;
        Image ShopButton;

        Player player;

        List<BackgroundElements> BgElement;
        List<Enemy> enemy;
        List<Ammo> bullet;

        int str;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            str = 0;

            Title  = Image.FromFile("Images\\BigTi.png");
            SrtImg = Image.FromFile("Images\\StartButton.gif");
            ExitImg = Image.FromFile("Images\\ExitButton.png");
            ShopButton = Image.FromFile("Images\\ShopButton.png");

            LoadPlayer();
            AmmoGeneration();
            Spawn();
            GenerateBG();
        }

        private void LoadPlayer()
        {
            player = new Player("Pity", new Ship(0, 0, 0, 3, 1, 0, 1), new Weapon(0, 1, 1, 1), new Engine(0, 1), 1, 0, 0, 0, 0);
        }

        private void AmmoGeneration()
        {
            bullet = new();
            for (int i = 0; i < 1; i++)
            {
                Ammo b = new();
                bullet.Add(b);
            }
        }

        private void Spawn()
        {
            enemy = new List<Enemy>();
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

        private void GenerateBG()
        {
            BgElement = new List<BackgroundElements>();
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
        private void Animator(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            Graphics Met = e.Graphics;
            Graphics Com = e.Graphics;
            Graphics Play = e.Graphics;
            Graphics En = e.Graphics;
            Graphics Am = e.Graphics;
            Graphics Tit = e.Graphics;
            Graphics Start = e.Graphics;
            Graphics Exit = e.Graphics;
            Graphics ShopBut = e.Graphics;

            if (str == 0)
            {
                Tit.DrawImage(Title, 150, 150, 128, 128);
                ShopBut.DrawImage(ShopButton, 100, 300, 128, 128);
                Start.DrawImage(SrtImg, 160, 200, 256, 256);
                Exit.DrawImage(ExitImg, 170, 320, 256, 256);
            }
            else
            {
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Player_Right_Timer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                Player_Left_Timer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                Player_Up_Timer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                Player_Down_Timer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                Ammo_Move_Timer.Start();
            }
        }

        private void Player_Left_Timer_Tick(object sender, EventArgs e)
        {
            if (player.x > 0)
            {
                player.x -= player.Ship.Speed;
            }
        }

        private void Player_Right_Timer_Tick(object sender, EventArgs e)
        {
            if (player.x < 500)
            {
                player.x += player.Ship.Speed;
            }
        }

        private void Player_Up_Timer_Tick(object sender, EventArgs e)
        {
            if (player.y > 0)
            {
                player.y -= player.Ship.Speed;
            }
        }

        private void Player_Down_Timer_Tick(object sender, EventArgs e)
        {
            if (player.y < 500)
            {
                player.y += player.Ship.Speed;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Player_Right_Timer.Stop();
            Player_Left_Timer.Stop();
            Player_Up_Timer.Stop();
            Player_Down_Timer.Stop();
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

        private void Enemy_Move_Timer_Tick(object sender, EventArgs e)
        {
            MoveEnemies();
        }

        private void MoveEnemies()
        {
            for (int i = 0; i < enemy.Count; i++)
            {
                enemy[i].Y += 3;

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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;

            if (mouse.X >= 261 && mouse.Y >= 318 && mouse.X < 261 + 75 && mouse.Y < 318 + 23)
            {
                str = 1;
                GameStart();
            }

            if (mouse.X >= 256 && mouse.Y >= 428 && mouse.X < 256 + 75 && mouse.Y < 428 + 23)
            {
                Close();
            }

            if (mouse.X >= 100 && mouse.Y >= 310 && mouse.X < 100 + 64 && mouse.Y < 310 + 64)
            {
                Shop shop = new Shop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                shop.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(shop);
                shop.Show();
            }

            if (mouse.X >= 100 && mouse.Y >= 310 && mouse.X < 100 + 64 && mouse.Y < 310 + 64)
            {
                Base base = new Base() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                base.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(base);
                base.Show();
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