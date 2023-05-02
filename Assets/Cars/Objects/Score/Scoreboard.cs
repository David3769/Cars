using Cars.Data;
using TMPro;
using UnityEngine;

namespace Cars.UI
{
    public class Scoreboard : MonoBehaviour
    {
        [SerializeField] private TMP_Text[] _linesScore;

        private int[] _score;

        private void OnEnable()
        { 
            UpdateScoreboard();
        }

        private void UpdateScoreboard()
        {
            _score = PlayerDataHandler.Instance.Player.Score;
            if (_score.Length == _linesScore.Length)
            {
                for (int i = 0; i < _score.Length; i++)
                {
                    _linesScore[i].text = $"{_score[i]}";
                }
            }
        }
    }
}
