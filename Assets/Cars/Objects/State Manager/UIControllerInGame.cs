using UnityEngine;

namespace Cars.Game
{
    public class UIControllerInGame : MonoBehaviour
    {
        [Header("UI elements")]
        [SerializeField] private GameObject _buttonPause;
        [SerializeField] private GameObject _panelPause;
        [SerializeField] private GameObject _panelGameOver;

        private void Update()
        {
            var currentState = StateManager.GetCurrentState();
            switch (currentState)
            {
                case States.Game:
                    CloseAll();
                    _buttonPause.SetActive(true);
                    break;
                case States.Pause:
                    CloseAll();
                    _panelPause.SetActive(true);
                    break;
                case States.GameOver:
                    CloseAll();
                    _panelGameOver.SetActive(true);
                    break;
            }
        }

        private void CloseAll()
        {
            _buttonPause.SetActive(false);
            _panelGameOver.SetActive(false);
            _panelPause.SetActive(false);
        }
    }
}