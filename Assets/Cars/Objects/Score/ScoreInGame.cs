using TMPro;
using UnityEngine;

namespace Cars.Game
{
    public class ScoreInGame : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        private void Update()
        {
            var score = RoadDrive.Instance.GetScore();
            _text.text = $"Score - {score}";
        }
    }
}