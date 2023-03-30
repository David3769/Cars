using TMPro;
using UnityEngine;

namespace Cars.Game.UI
{
    public class DistanceUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _distance;

        private RoadDrive _road;

        private void Start()
        {
            if (_road == null)
                _road = FindObjectOfType<RoadDrive>();
        }

        private void Update()
        {
            _distance.text = _road.GetDriveDistance().ToString();
        }
    }
}