using UnityEngine;

namespace Cars.Audio
{
    public class MusicPlayerController : MonoBehaviour
    {
        public static MusicPlayerController Instance;

        [SerializeField] private AudioSource _musicEngine;
        [SerializeField] private AudioSource _musicEffectGameOver;

        private void Start()
        {
            if (Instance == null)
                Instance = this;
        }

        public void PauseMusicEngine() => _musicEngine.Pause();

        public void UnPauseMusicEngine() => _musicEngine.UnPause();

        public void PlayMusicEffectGameOver() => _musicEffectGameOver.Play();
    }
}
