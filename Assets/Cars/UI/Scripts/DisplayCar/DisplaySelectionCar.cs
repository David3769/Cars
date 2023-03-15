using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Cars.Player;

namespace Cars.UI
{
    public class DisplaySelectionCar : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _price;
        [SerializeField] private ChangeCar _changeCar;
        [SerializeField] private PlayerCar _playerCar;

        public void Display(Car car)
        {
            _image.sprite = car.Sprite;
            _price.text = car.Price.ToString();
        }

        private void Update()
        {
            if (_changeCar != null && _playerCar != null)
            {
                var currentIndex = _changeCar.GetCurrentCar().Index;

                if (_playerCar.CheckOnMyCar(currentIndex))
                    _price.text = "Куплено";
            }
        }
    }
}