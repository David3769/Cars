using TMPro;
using UnityEngine;

namespace Cars.Game.Lollipop
{
    public class LollipopInGame : MonoBehaviour
    {
        [SerializeField] private TMP_Text _lollipopUI;

        private int _lollipop;
        private int _collected;

        private void Awake()
        {
            _lollipop = PlayerPrefs.GetInt("Lollipop");
            _lollipopUI.text = _lollipop.ToString();

            UpdateLollipopUI();
        }

        public void AddLollipop(int added)
        {
            _collected += added;
            _lollipop += added;
        }

        private void UpdateLollipopUI()
        {
            _lollipopUI.text = _lollipop.ToString();
            Invoke("UpdateLollipopUI", 1f);
        }
    }
}