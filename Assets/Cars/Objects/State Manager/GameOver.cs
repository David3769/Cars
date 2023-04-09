using Cars.Data;
using TMPro;
using UnityEngine;

namespace Cars.Game
{
    public class GameOver : MonoBehaviour
    {
        public static GameOver Instance { get; private set; }

        [SerializeField] private TMP_Text _collectedLollipop;

        private void Start()
        {
            if (Instance == null)
                Instance = this;
        }

        public void SetGameOver()
        {
            GameFileHandler.Instance.Save();
            StateManager.SetGameOver();
        }

        public void ButtonSetGame()
        {
            StateManager.SetGame();
        }

        public void ButtonSetPause()
        {
            StateManager.SetPause();
        }
    }
}
