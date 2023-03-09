using Cars.UI;
using UnityEngine;

namespace Cars.Player
{
    public class BuyCar : MonoBehaviour
    {
        [SerializeField] private ChangeCar _changeCar;
        [SerializeField] private PlayerInformation _playerInformation;

        public void Buy()
        {
            var priceCar = _changeCar.GetCurrentCar().Price;
            if (_playerInformation.TakeLollipops(priceCar))
                _playerInformation.AddCar(_changeCar.GetCurrentCar().Index);
        }
    }
}

