using Cars.Game.Lollipop;
using TMPro;
using UnityEngine;

namespace Cars.Game.Player
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private TMP_Text _collectedLollipop;
        [SerializeField] private LollipopInGame _lollipop;

        private void Start()
        {
            if (_lollipop == null)
                _lollipop = FindObjectOfType<LollipopInGame>().GetComponent<LollipopInGame>();
        }

        public void SetGameOver()
        {
            StateManager.SetGameOver();

            _collectedLollipop.text = _lollipop.Collected.ToString();
            _lollipop.SaveLollipop();
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
