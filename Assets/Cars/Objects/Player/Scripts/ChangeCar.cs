using Cars.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.UI
{
    public class ChangeCar : MonoBehaviour
    {
        public static ChangeCar Instance { get; private set; }

        [SerializeField] private ScriptableObject[] _cars;
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _price;

        private PlayerDataHandler _playerDataHandler;

        private void OnEnable()
        {
            if (Instance == null)
                Instance = this;

            _playerDataHandler = PlayerDataHandler.Instance;
            _playerDataHandler.CurrentIndexCar = 0;
            _playerDataHandler.SetSelectionIndexCar();
            UpdateUI();
        }

        public void Change(int change)
        {
            var index = ClickHandler(change);
            var car = _cars[index] as PlayerScriptableObject;
            ChangeUI(car);
        }

        private int ClickHandler(int change)
        {
            var index = _playerDataHandler.CurrentIndexCar;
            index += change;

            if (index < 0)
                index = _cars.Length - 1;
            else if (index > _cars.Length - 1)
                index = 0;

            _playerDataHandler.CurrentIndexCar = index;
            _playerDataHandler.SetSelectionIndexCar();
            return index;
        }

        private void ChangeUI(PlayerScriptableObject car)
        {
            _image.sprite = car.Sprite;
            var isMyCar = _playerDataHandler.CheckOnMyCar();
            if (isMyCar)
                _price.text = "Куплено";
            else
                _price.text = car.Price.ToString();
        }

        public void UpdateUI()
        {
            if (PlayerDataHandler.Instance.CheckOnMyCar())
                _price.text = "Куплено";
            else
            {
                var car = _cars[PlayerDataHandler.Instance.CurrentIndexCar] as PlayerScriptableObject;
                _price.text = $"{car.Price}";
            }
        }

        public PlayerScriptableObject GetPlayerScriptableObject()
        {
            return _cars[PlayerDataHandler.Instance.CurrentIndexCar] 
                as PlayerScriptableObject;
        }
    }
}