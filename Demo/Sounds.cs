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
        private static WindowsMediaPlayer gameMedia;
        private static WindowsMediaPlayer shootMedia;
        private static WindowsMediaPlayer shootMedia2;
        private static WindowsMediaPlayer enemyDieMedia;
        private static WindowsMediaPlayer playerDieMedia;

        private static int volume = 50;
        private static int volumesfx = 50;

        public Sounds()
        {
            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            shootMedia2 = new WindowsMediaPlayer();
            enemyDieMedia = new WindowsMediaPlayer();
            playerDieMedia = new WindowsMediaPlayer();

            gameMedia.settings.volume = volume;

            shootMedia.settings.volume = volumesfx;
            shootMedia2.settings.volume = volumesfx;

            enemyDieMedia.settings.volume = volumesfx;
            playerDieMedia.settings.volume = volumesfx;


            gameMedia.settings.autoStart = false;
            gameMedia.URL = "songs\\GameSongs.mp3";

            shootMedia.settings.autoStart = false;
            shootMedia.URL = "songs\\Gunshot_Sound_Effect.mp3";

            enemyDieMedia.settings.autoStart= false;
            enemyDieMedia.URL = "songs\\EnemyDie.mp3";

            playerDieMedia.settings.autoStart = false;
            playerDieMedia.URL = "songs\\PlayerDie.mp3";

            shootMedia2.settings.autoStart = false;
            shootMedia2.URL = "songs\\ShootSongs.mp3";

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
        public void ShootSoundstop()
        {
            shootMedia.controls.stop();
        }
        public void sfxTest()
        {
            shootMedia2.controls.play();
            shootMedia2.settings.setMode("loop", true);
        }
        public void sfxTestStop()
        {
            shootMedia2.controls.stop();
            shootMedia2.settings.setMode("loop", false);
        }
        public void EnemyDieSound()
        {
            enemyDieMedia.controls.play();
        }

        public void PlayerDieSound()
        {
            playerDieMedia.controls.play();
        }


        public void MusicVolumeSet(int VolumeMusic)
        {
            volume = VolumeMusic;
            gameMedia.settings.volume = VolumeMusic;
        }
        public void VolumeSFXSet(int SETVolumesfx)
        {
            volumesfx = SETVolumesfx;
            shootMedia.settings.volume = SETVolumesfx;
            shootMedia2.settings.volume = SETVolumesfx;
            enemyDieMedia.settings.volume = SETVolumesfx;
            playerDieMedia.settings.volume = SETVolumesfx;
        }
        public int MusicVolumeGet()
        {
            return volume;
        }
        public int SfxVolumeGet()
        {
            return volumesfx;
        }
    }
}
