using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cars.UI
{
    public class AnimationBuyCar : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textLog;
        [SerializeField] private GameObject _panel;

        public void SetActiveAnimation(string textLog, Color color)
        {
            _panel.SetActive(true);
            var setColor = _panel.GetComponent<Image>();
            setColor.color = color;
            _textLog.text = textLog;

            StartCoroutine(Animation());
        }

        IEnumerator Animation ()
        {
            Debug.Log("coroutine");
            yield return new WaitForSeconds(1);
            _panel.SetActive(false);
        }
    }
}