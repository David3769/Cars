using Cars.Data;
using TMPro;
using UnityEngine;

namespace Cars.UI
{
    public class LollipopUIDraw : MonoBehaviour
    {
        public static LollipopUIDraw Instance { get; private set; }

        [SerializeField] private TMP_Text _lollipopUI;

        private int _lollipop;

        private void Start()
        {
            if (Instance == null)
                Instance = this;

            UpdateLollipop();
        }

        public void UpdateLollipop()
        {
            _lollipop = PlayerDataHandler.Instance.Player.Lollipop;
            _lollipopUI.text = $"{_lollipop}";
        }
    }
}