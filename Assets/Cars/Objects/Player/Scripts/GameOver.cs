using Cars.Game.Lollipop;
using TMPro;
using UnityEngine;

namespace Cars.Game.Player
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private TMP_Text _collectedLollipop;

        private LollipopInGame _lollipop;
        private RoadDrive _road;

        private void Start()
        {
            if (_lollipop == null)
                _lollipop = FindObjectOfType<LollipopInGame>();

            if (_road == null)
                _road = FindObjectOfType<RoadDrive>();
        }

        public void SetGameOver()
        {
            StateManager.SetGameOver();

            _collectedLollipop.text = _lollipop.Collected.ToString();
            _lollipop.SaveLollipop();
            _road.SaveDriveDistance();
        }

        public void SetRestartGame()
        {
            StateManager.SetGame();
        }

        public void SetPause()
        {
            StateManager.SetPause();
        }
    }
}
