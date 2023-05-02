using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.Game
{
    public class BoostEffect : MonoBehaviour
    {
        public static BoostEffect Instance { get; private set; }

        public Effects Effect;

        [SerializeField] private int _setCountEffect;
        [SerializeField] private GameObject _shield;
        [SerializeField] private Sprite[] _icons;
        [SerializeField] private GameObject _image;
        
        private int _countEffect;

        private void Start()
        {
            if (Instance == null)
                Instance = this;

            Effect = Effects.None;
        }

        public void SetEffect(Effects effect)
        {
            Effect = effect;
            _countEffect = _setCountEffect;
            UpdateEffect();
        }

        private void UpdateEffect()
        {
            switch (Effect)
            {
                case Effects.None:
                    SetEffect(false);
                    break;
                case Effects.X2:
                    SetEffect(false, _icons[0]);
                    break;
                case Effects.Shield:
                    SetEffect(true, _icons[1]);
                    break;
            }
        }

        private void SetEffect(bool isShield, Sprite icon = null)
        {
            _shield.SetActive(isShield);
            if (icon == null)
                _image.SetActive(false);
            else
            {
                _image.SetActive(true);
                _image.GetComponent<Image>().sprite = icon;
            }
        }

        public void SubtractEffect()
        {
            _countEffect--;
            if (_countEffect == 0)
            {
                Effect = Effects.None;
                UpdateEffect();
            }
        }
    }

    public enum Effects
    {
        None,
        X2,
        Shield
    }
}