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

            gameMedia.settings.autoStart = false;
            gameMedia.URL = "songs\\GameSongs.mp3";

            shootMedia.settings.autoStart = false;
            shootMedia.URL = "songs\\ShootSongs.mp3";

            enemyDieMedia.settings.autoStart= false;
            enemyDieMedia.URL = "songs\\EnemyDie.mp3";

            playerDieMedia.settings.autoStart = false;
            playerDieMedia.URL = "songs\\PlayerDie.mp3";

        }
        public void GameMusic()
        {
            gameMedia.controls.play();
            gameMedia.settings.setMode("loop", true);
        }

        public void GameEnd()
        {
            gameMedia.controls.stop();
        }

        public void ShootSound()
        {
            shootMedia.controls.play();
        }

        public void EnemyDieSound()
        {
            enemyDieMedia.controls.play();
        }

        public void PlayerDieSound()
        {
            playerDieMedia.controls.play();
        }
    }
}
