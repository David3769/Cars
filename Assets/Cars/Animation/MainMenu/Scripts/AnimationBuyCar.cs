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
            _panel.GetComponent<Image>().color = color;
            _textLog.text = textLog;

            StartCoroutine(Animation());
        }

        private IEnumerator Animation ()
        {
            Debug.Log("coroutine");
            yield return new WaitForSeconds(5f);
            _panel.SetActive(false);
        }
    }
}