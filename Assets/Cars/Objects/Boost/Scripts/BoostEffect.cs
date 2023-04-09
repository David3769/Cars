using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.Game
{
    public class BoostEffect : MonoBehaviour
    {
        public static BoostEffect Instance { get; private set; }

        [SerializeField] private TMP_Text _text;
        [SerializeField] private int _setCountEffect;
        
        private int _countEffect;
        private Image _image;

        public Effects Effect;

        private void Start()
        {
            if (Instance == null)
                Instance = this;

            _image = GetComponent<Image>();
            _image.color = Color.clear;
            Effect = Effects.None;
            _text.gameObject.SetActive(false);
        }

        public void SetEffect(Color color, Effects effect)
        {
            _text.gameObject.SetActive(true);
            _image.color = color;
            Effect = effect;
            _countEffect = _setCountEffect;
            _text.text = _countEffect.ToString();
        }

        public void SubtractEffect()
        {
            _countEffect--;
            _text.text = _countEffect.ToString();
            if (_countEffect == 0)
            {
                Effect = Effects.None;
                _image.color = Color.clear;
                _text.gameObject.SetActive(false);
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