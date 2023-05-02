using Cars.Audio;
using Cars.Game;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Cars.Animation
{
    public class AnimExitFromPause : MonoBehaviour
    {
        public static AnimExitFromPause Instance { get; private set; }

        [SerializeField] private TMP_Text _text;
        [SerializeField] private int _endFontSize = 150;
        [SerializeField] private int _startFontSize = 300;
        [SerializeField] private int _startNumber = 3;
        [SerializeField] private float _timeAnim = 150;

        private void Start()
        {
            if (Instance == null)
                Instance = this;
        }

        public void StartAnim() => StartCoroutine(Anim());

        private IEnumerator Anim()
        {
            int currentNumber = _startNumber;
            while (true)
            {
                if (currentNumber <= 0)
                {
                    _text.text = "";
                    GameController.Instance.SetGame();
                    FindObjectOfType<MusicPlayerController>().UnPauseMusicEngine();
                    break;
                }
                _text.fontSize = _startFontSize;
                _text.text = $"{currentNumber}";
                currentNumber--;
                while (_text.fontSize > _endFontSize)
                {
                    _text.fontSize -= _timeAnim * Time.deltaTime;
                    yield return new WaitForSeconds(0.001f);
                }
                yield return new WaitForSeconds(0.001f);
            }
        }
    }
}
