using Cars.Data;
using TMPro;
using UnityEngine;

namespace Cars.Game
{
    public class GameOver : MonoBehaviour
    {
        public static GameOver Instance { get; private set; }

        [SerializeField] private GameObject _panelGameOver;

        private int[] _scores;

        private void Start()
        {
            if (Instance == null)
                Instance = this;
            _scores = PlayerDataHandler.Instance.Player.Score;
        }

        public void SetGameOver()
        {
            _panelGameOver.SetActive(true);
            GameController.Instance.SetStopGame();
            UpdateScoreInGameData();
            GameFileHandler.Instance.Save();
        }

        private void UpdateScoreInGameData()
        {
            var score = RoadDrive.Instance.GetScore();
            if (_scores[_scores.Length - 1] < score)
            {
                _scores[_scores.Length - 1] = score;
                PlayerDataHandler.Instance.SortScore();
            }
        }
    }
}
