using Cars.Audio;
using UnityEngine;

namespace Cars.Game
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance { get; private set; }

        public bool IsGame { get; private set; }

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            SetGame();
        }

        public void SetGame()
        {
            IsGame = true;
        }

        public void SetStopGame()
        {
            IsGame = false;
            FindObjectOfType<MusicPlayerController>().PauseMusicEngine();
        }
    }
}
