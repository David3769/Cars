using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.Game.Player
{
    public class BoostEffect : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private int _countEffect;

        private Effects _effect;

        public Image _image;

        public Effects Effect => _effect;

        private void Start()
        {
            _image = GetComponent<Image>();
            _image.color = Color.clear;

            _effect = Effects.None;
            _text.gameObject.SetActive(false);
        }

        public void SetEffect(Color color, Effects effect)
        {
            _image.color = color;
            _effect = effect;
            _text.gameObject.SetActive(true);
            SetEffect();
        }

        private void SetEffect()
        {
            _countEffect = 5;
            UpdateCountEffectUI();
        }
        public void SubtractEffect()
        {
            _countEffect--;

            if (_countEffect == 0)
            {
                _effect = Effects.None;
                _image.color = Color.clear;
                _text.gameObject.SetActive(false);
            }

            UpdateCountEffectUI();
        }

        private void UpdateCountEffectUI()
        {
            _text.text = _countEffect.ToString();
        }
    }

    public enum Effects
    {
        None,
        X2,
        Shield
    }
}