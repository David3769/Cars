using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Cars.Player;

namespace Cars.UI
{
    public class DisplaySelectionCar : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _price;
        [SerializeField] private ChangeCar _changeCar;
        [SerializeField] private PlayerInformation _playerInformation;

        public void Display(Car car)
        {
            _image.sprite = car.Sprite;
            _price.text = car.Price.ToString();
        }

        private void Update()
        {
            var currentCarIndex = _changeCar.GetCurrentCar().Index;
            if (_playerInformation.CheckInMyCar(currentCarIndex))
                _price.text = "Куплено";
        }
    }
}