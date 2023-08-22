using System.Media;
using System.Windows.Media;

namespace ChopperChopper.Services
{
    public class SoundEngine
    {
        public SoundEngine()
        {
            WelcomeMusicPlayer = new SoundPlayer(Properties.Resources.Welcome);
            BackgroundMusicPlayer = new SoundPlayer(Properties.Resources.BackgroundMusic);
            ExplosionSoundEffectPlayer = new SoundPlayer(Properties.Resources.Explosion);
            GameOverMusicPlayer = new SoundPlayer(Properties.Resources.GameOver);
            NewHighScoreMusicPlayer = new SoundPlayer(Properties.Resources.NewHighScore);
        }

        public SoundPlayer WelcomeMusicPlayer { get; set; }
        public SoundPlayer BackgroundMusicPlayer { get; set; }
        public SoundPlayer ExplosionSoundEffectPlayer { get; set; }
        public SoundPlayer GameOverMusicPlayer { get; set; }
        public SoundPlayer NewHighScoreMusicPlayer { get; set; }

        public void StopAllSounds()
        {
            WelcomeMusicPlayer.Stop();
            BackgroundMusicPlayer.Stop();
            ExplosionSoundEffectPlayer.Stop();
            GameOverMusicPlayer.Stop();
            NewHighScoreMusicPlayer.Stop();
        }
    }
}
