using Cars.Player;
using TMPro;
using UnityEngine;

namespace Cars.UI
{
    public class Lollipop : MonoBehaviour
    {
        [SerializeField] private PlayerInformation _playerInformation;
        [SerializeField] private TMP_Text _lollipopUI;

        private int _lollipop;

        public void UpdateLollipop()
        {
            _lollipop = _playerInformation.Lollipop;
            _lollipopUI.text = $"{_lollipop}";
        }
    }
}