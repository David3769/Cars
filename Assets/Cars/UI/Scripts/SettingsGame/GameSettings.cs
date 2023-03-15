using UnityEngine;

namespace Cars.UI.Settings
{
    public class GameSettings : MonoBehaviour
    {
        [SerializeField] private bool _isMusic;

        private ButtonFunctions _buttonFunctions;

        private void Start()
        {
            _buttonFunctions = new ButtonFunctions();
        }

        public void IsMusic()
        {
            if (_isMusic == true)
                _isMusic = false;
            else if (_isMusic == false)
                _isMusic = true;
        }

        public void ResetGame()
        {
            _buttonFunctions.ResetCar();
        }
    }
}