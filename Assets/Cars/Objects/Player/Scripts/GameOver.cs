using Cars.Game.Lollipop;
using TMPro;
using UnityEngine;

namespace Cars.Game.Player
{
    public class GameOver : MonoBehaviour
    {
        private States _state = States.Game;

        public States State => _state;
        
        [SerializeField] private GameObject _menuGameOver;
        [SerializeField] private GameObject _buttonPause;
        [SerializeField] private TMP_Text _collectedLollipop;
        [SerializeField] private LollipopInGame _lollipop;

        private void Start()
        {
            _state = States.Game;

            if (_lollipop == null)
                _lollipop = FindObjectOfType<LollipopInGame>().GetComponent<LollipopInGame>();
        }

        public void SetGameOver()
        {
            _state = States.GameOver;
            Time.timeScale = 0f;

            _buttonPause?.SetActive(false);
            _menuGameOver?.SetActive(true);

            _collectedLollipop.text = _lollipop.Collected.ToString();
            _lollipop.SaveLollipop();
        }

        public void SetRestartGame()
        {
            _state = States.Game;
            Time.timeScale = 1f;
        }
    }
}
