using Cars.Game.Lollipop;
using TMPro;
using UnityEngine;

namespace Cars.Game.Player
{
    public class GameOver : IGameOver
    {
        public States State { get; set; }
        
        [SerializeField] private GameObject _menuGameOver;
        [SerializeField] private GameObject _buttonPause;
        [SerializeField] private TMP_Text _collectedLollipop;

        private ILollipopData _lollipop = new LollipopInGame();

        public void SetGameOver()
        {
            State = States.GameOver;
            Time.timeScale = 0f;

            _buttonPause?.SetActive(false);
            _menuGameOver?.SetActive(true);

            _collectedLollipop.text = _lollipop.Collected.ToString();
            _lollipop.SaveLollipop();
        }

        public void SetRestartGame()
        {
            State = States.Game;
            Time.timeScale = 1f;
        }
    }
}
