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
        Image BaseButton;
        public Image OptionButton;





        public Form1()
        {
            InitializeComponent();

            Title = Image.FromFile("Images\\BigTi.png");
            SrtImg = Image.FromFile("Images\\StartButton.gif");
            ExitImg = Image.FromFile("Images\\ExitButton.png");
            ShopButton = Image.FromFile("Images\\ShopButton.png");
            BaseButton = Image.FromFile("Images\\BaseButton.png");
            OptionButton = Image.FromFile("Images\\Gear.png");
            

            ImageAnimator.Animate(SrtImg, this.Animator);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            Graphics Tit = e.Graphics;
            Graphics Start = e.Graphics;
            Graphics Exit = e.Graphics;
            Graphics ShopBut = e.Graphics;
            Graphics BaseBut = e.Graphics;
            Graphics OptionBut = e.Graphics;

            BaseBut.DrawImage(BaseButton, 150, 444, 32, 32);
            Tit.DrawImage(Title, 150, 150, 256, 128);
            ShopBut.DrawImage(ShopButton, 100, 300, 128, 128);
            Start.DrawImage(SrtImg, 160, 200, 256, 256);
            Exit.DrawImage(ExitImg, 170, 320, 256, 256);
            OptionBut.DrawImage(OptionButton, 400,325, 64, 64);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;


            if (mouse.X >= 261 && mouse.Y >= 318 && mouse.X < 261 + 75 && mouse.Y < 318 + 23)
            {
                Game game = new Game() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                game.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(game);
                game.Show();
            }
            else if (mouse.X >= 256 && mouse.Y >= 428 && mouse.X < 256 + 75 && mouse.Y < 428 + 23)
            {
                Close();
            }
            else if (mouse.X >= 100 && mouse.Y >= 310 && mouse.X < 100 + 64 && mouse.Y < 310 + 64)
            {
                Shop shop = new Shop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                shop.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(shop);
                shop.Show();
            }
            else if (mouse.X >= 150 && mouse.Y >= 444 && mouse.X < 150 + 32 && mouse.Y < 444 + 32)
            {
                Base b = new Base() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                b.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(b);
                b.Show();
            }
            else if (mouse.X >= 400 && mouse.Y >= 325 && mouse.X < 400 + 64 && mouse.Y < 325+ 64)
            {
                Sound soundsSettigs = new Sound() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                soundsSettigs.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(soundsSettigs);
                soundsSettigs.Show();
            }

        }

        private void Animator(object? sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}