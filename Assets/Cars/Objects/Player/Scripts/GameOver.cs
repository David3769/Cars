using Cars.Game.Lollipop;
using TMPro;
using UnityEngine;

namespace Cars.Game.Player
{
    public class GameOver : MonoBehaviour
    {
        public States State;
        
        [SerializeField] private GameObject _menuGameOver;
        [SerializeField] private GameObject _buttonPause;
        [SerializeField] private TMP_Text _collectedLollipop;
        [SerializeField] private LollipopInGame _lollipop;

        private void Start()
        {
            State = States.Game;

            if (_lollipop == null)
                _lollipop = FindObjectOfType<LollipopInGame>().GetComponent<LollipopInGame>();
        }

        public void SetGameOver()
        {
            State = States.GameOver;
            Time.timeScale = 0f;

            _buttonPause?.SetActive(false);
            _menuGameOver?.SetActive(true);

            _collectedLollipop.text = _lollipop.Collected.ToString();
            _lollipop.SaveLollipop();
        }
    }
}
