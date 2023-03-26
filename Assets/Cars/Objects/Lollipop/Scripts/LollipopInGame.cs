using TMPro;
using UnityEngine;

namespace Cars.Game.Lollipop
{
    public class LollipopInGame : MonoBehaviour
    {
        [SerializeField] private TMP_Text _lollipopUI;

        private int _lollipop;

        public int Collected { get; private set; }

        private void Awake()
        {
            _lollipop = PlayerPrefs.GetInt("Lollipop");
            _lollipopUI.text = _lollipop.ToString();

            UpdateLollipopUI();
        }

        public void AddLollipop(int added)
        {
            Collected += added;
            _lollipop += added;
        }

        public void SaveLollipop()
        {
            PlayerPrefs.SetInt("Lollipop", _lollipop);
        }

        private void UpdateLollipopUI()
        {
            _lollipopUI.text = _lollipop.ToString();
            Invoke("UpdateLollipopUI", 1f);
        }
    }
}