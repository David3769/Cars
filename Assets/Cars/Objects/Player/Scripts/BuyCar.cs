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

        private int _priceCar;
        private int _indexCar;

        private void Start()
        {
            _priceCar = _changeCar.GetCurrentCar().Price;
            _indexCar = _changeCar.GetCurrentCar().Index;
        }

        public void Buy()
        {
            if (ExceptionCheck() == false)
                return;

            _lollipop.Take(_priceCar);
            _playerCar.AddCar(_indexCar);

            ActiveAnimation("Покупка прошла успешно!", Color.green);
        }

        private bool ExceptionCheck()
        {
            if (_playerCar.CheckInMyCar(_indexCar))
            {
                ActiveAnimation("Данная машина куплена.", Color.red);
                return false;
            }
            else if (_lollipop.LollipopCount < _priceCar)
            {
                ActiveAnimation("Недостаточно чупа чупсов.", Color.red);
                return false;
            }

            return true;
        }

        private void ActiveAnimation(string text, Color color)
        {
            _animationBuyCar.SetActiveAnimation(text, color);
        }
    }
}

