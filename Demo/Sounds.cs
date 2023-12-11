using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Demo
{
    public class Sounds
    {
        private WindowsMediaPlayer gameMedia;
        private WindowsMediaPlayer shootMedia;
        private WindowsMediaPlayer enemyDieMedia;
        private WindowsMediaPlayer playerDieMedia;

        public Sounds()
        {
            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            enemyDieMedia = new WindowsMediaPlayer();
            playerDieMedia = new WindowsMediaPlayer();

            gameMedia.URL = "D:\\visual repos\\ciganybunozes\\Demo\\songs\\GameSongs.mp3";

            shootMedia.settings.autoStart = false;
            shootMedia.URL = "D:\\visual repos\\ciganybunozes\\Demo\\songs\\ShootSongs.mp3";

            enemyDieMedia.settings.autoStart= false;
            enemyDieMedia.URL = "D:\\visual repos\\ciganybunozes\\Demo\\songs\\EnemyDie.mp3";

            playerDieMedia.settings.autoStart = false;
            playerDieMedia.URL = "D:\\visual repos\\ciganybunozes\\Demo\\songs\\PlayerDie.mp3";

        }
        public void JatekHangLejatszas()
        {
            gameMedia.controls.play();
            gameMedia.settings.setMode("loop", true);
        }

        public void LovoHangLejatszas()
        {
            shootMedia.controls.play();
        }

        public void EllenfelMeghalHangLejatszas()
        {
            enemyDieMedia.controls.play();
        }

        public void JatekosMeghalHangLejatszas()
        {
            playerDieMedia.controls.play();
        }
    }
}
