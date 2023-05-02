using Cars.Data;
using Cars.UI;
using TMPro;
using UnityEngine;

namespace Cars.Main
{
    public class BuyCarHandler : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textShopPanel;
        [SerializeField] private GameObject _shopPanel;

        private PlayerDataHandler _player;

        private void OnEnable()
        {
            _player = PlayerDataHandler.Instance;
            _shopPanel.SetActive(false);
        }

        public void OpenShopPanel()
        {
            if (_player.CheckOnMyCar() == false)
                _textShopPanel.text = $"Купить за: {GetPriceCar()}?";
        }

        private int GetPriceCar() => ChangeCar.Instance.GetPlayerScriptableObject().Price;

        public void Buy()
        {
            var isMyCar = _player.CheckOnMyCar();
            if (isMyCar == false)
            {
                var price = GetPriceCar();
                if (_player.Player.Lollipop >= price)
                {
                    _player.TakeLollipop(price);
                    _player.AddCar(PlayerDataHandler.Instance.CurrentIndexCar);
                    GameFileHandler.Instance.Save();
                    ChangeCar.Instance.UpdateUI();
                }
            }
        }
    }
}

