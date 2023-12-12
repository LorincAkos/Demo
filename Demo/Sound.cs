using System;
using System.Windows.Forms;
using WMPLib;

namespace Demo
{
    public partial class Sound : Form
    {
        private HangKezelo hangKezelo;

        public Sound()
        {
            InitializeComponent();
            hangKezelo = new HangKezelo();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            hangKezelo.BeallitHangerok(((TrackBar)sender).Value);
        }

        private void volumeTrackBar2_Scroll(object sender, EventArgs e)
        {
            hangKezelo.BeallitHangero(((TrackBar)sender).Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Csúszka inicializálása
            TrackBar volumeTrackBar = InicializalCsuszkat(50, volumeTrackBar_Scroll);
            TrackBar volumeTrackBar2 = InicializalCsuszkat(50, volumeTrackBar2_Scroll);

            // Csúszka hozzáadása a Form-hoz
            Controls.Add(volumeTrackBar);
            Controls.Add(volumeTrackBar2);

            hangKezelo.JatekHangLejatszas();
        }

        private TrackBar InicializalCsuszkat(int kezdoErtek, EventHandler esemenyKezelo)
        {
            TrackBar volumeTrackBar = new TrackBar();
            volumeTrackBar.Minimum = 0;
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Value = kezdoErtek;
            volumeTrackBar.TickFrequency = 10;
            volumeTrackBar.Orientation = Orientation.Horizontal;
            volumeTrackBar.Scroll += esemenyKezelo;

            return volumeTrackBar;
        }
    }

    internal class HangKezelo
    {
        private WindowsMediaPlayer gameMedia;
        private WindowsMediaPlayer shootMedia;
        private WindowsMediaPlayer enemyDieMedia;
        private WindowsMediaPlayer playerDieMedia;

        public HangKezelo()
        {
            gameMedia = LetrehozWindowsMediaPlayer("D:\\visual repos\\ciganybunozes\\Demo\\songs\\GameSongs.mp3", true);
            shootMedia = LetrehozWindowsMediaPlayer("D:\\visual repos\\ciganybunozes\\Demo\\songs\\ShootSongs.mp3", true);
            enemyDieMedia = LetrehozWindowsMediaPlayer("D:\\visual repos\\ciganybunozes\\Demo\\songs\\EnemyDie.mp3", true);
            playerDieMedia = LetrehozWindowsMediaPlayer("D:\\visual repos\\ciganybunozes\\Demo\\songs\\PlayerDie.mp3", true);

            gameMedia.settings.volume = 50;
            shootMedia.settings.volume = 50;
            enemyDieMedia.settings.volume = 50;
            playerDieMedia.settings.volume = 50;
        }

        public void BeallitHangerok(int ertek)
        {
            gameMedia.settings.volume = ertek;
            shootMedia.settings.volume = ertek;
            enemyDieMedia.settings.volume = ertek;
            playerDieMedia.settings.volume = ertek;
        }

        public void BeallitHangero(int ertek)
        {
            shootMedia.settings.volume = ertek;
            enemyDieMedia.settings.volume = ertek;
            playerDieMedia.settings.volume = ertek;
        }

        public void JatekHangLejatszas()
        {
            gameMedia.controls.play();
            shootMedia.controls.play();
            enemyDieMedia.controls.play();
            playerDieMedia.controls.play();
        }

        private WindowsMediaPlayer LetrehozWindowsMediaPlayer(string file, bool loop)
        {
            var player = new WindowsMediaPlayer();
            player.URL = file;
            player.settings.setMode("loop", loop);
            return player;
        }
    }
}
