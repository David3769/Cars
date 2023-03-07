using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.UI
{
    public class DisplaySelectionCar : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _price;

        public void Display(Car car)
        {
            _image.sprite = car.Sprite;
            _price.text = car.Price.ToString();
        }
    }
}