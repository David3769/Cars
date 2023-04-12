using TMPro;
using UnityEngine;

namespace Cars.Game
{
    public class SpeedPlayer : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        private void Update()
        {
            var speed = RoadDrive.Instance.GetSpeed();
            _text.text = $"Speed - {speed}";
        }
    }
}