using Cars.Data;
using Cars.UI;
using UnityEngine;

namespace Cars.Player
{
    public class BuyCar : MonoBehaviour
    {
        [SerializeField] private ChangeCar _changeCar;
        [SerializeField] private PlayerCar _playerCar;
        [SerializeField] private Lollipop _lollipop;
        [SerializeField] private AnimationBuyCar _animationBuyCar;

        private int _price;
        private int _index;

        private void Update()
        {
            if (_changeCar != null)
            {
                _price = _changeCar.GetCurrentCar().Price;
                _index = _changeCar.GetCurrentCar().Index;
            }
        }


        public void Buy()
        {
            if (ExceptionCheck() == false)
                return;

            _playerCar?.AddCar(_index);
            _lollipop?.Take(_price);

            ActiveAnimation(Color.green);
            GameFileHandler.Save(_playerCar.GetMyCar());
        }

        private bool ExceptionCheck()
        {
            if (_playerCar.CheckOnMyCar(_index))
            {
                ActiveAnimation(Color.red, "Данная машина куплена.");
                return false;
            }
            else if (_lollipop.LollipopCount < _price)
            {
                ActiveAnimation(Color.red, "Недостаточно чупа чупсов.");
                return false;
            }

            return true;
        }

        private void ActiveAnimation(Color color, string text)
        {
            _animationBuyCar.SetActiveAnimation(color, text);
        }

        private void ActiveAnimation(Color color)
        {
            _animationBuyCar.SetActiveAnimation(color);
        }
    }
}

