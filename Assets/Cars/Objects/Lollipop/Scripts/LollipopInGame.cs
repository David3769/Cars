using TMPro;
using UnityEngine;

namespace Cars.Game.Lollipop
{
    public class LollipopInGame : ILollipopData, ILollipop
    {
        [SerializeField] private TMP_Text _lollipopUI;

        private static int _lollipop;

        public int Collected { get; set; }

        public void LoadLollipop()
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
        }
    }
}