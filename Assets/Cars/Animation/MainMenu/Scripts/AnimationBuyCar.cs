using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.UI
{
    public class AnimationBuyCar : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textLog;
        [SerializeField] private GameObject _displayAnim;
        [SerializeField] private float _timeAnimation = 5f;

        private Image _imageDisplay;
        private const string _textBuyCar = "Покупка прошла успешно!";

        private void Start()
        {
            _imageDisplay = _displayAnim.GetComponent<Image>();
        }

        public void SetActiveAnimation(Color color, string textLog = _textBuyCar)
        {
            _displayAnim.SetActive(true);
            SetOptions(textLog, color);

            StartCoroutine(Animation(_timeAnimation));
        }

        private void SetOptions(string textLog, Color color)
        {
            _imageDisplay.color = color;
            _textLog.text = textLog;
        }

        private IEnumerator Animation(float time)
        {
            yield return new WaitForSeconds(time);
            _displayAnim.SetActive(false);
        }
    }
}