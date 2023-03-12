using Cars.Data;
using TMPro;
using UnityEngine;

namespace Cars.UI
{
    public class Lollipop : MonoBehaviour
    {
        [SerializeField] private TMP_Text _lollipopUI;
        [SerializeField] private int _pocketLollipops;

        public int LollipopCount { get; private set; }

        private void Start()
        {
            LollipopCount = _pocketLollipops;
        }

        public void Update()
        {
            _lollipopUI.text = $"{LollipopCount}";
        }

        public bool Take(int count)
        {
            if (count <= 0 || count > LollipopCount)
                return false;

            LollipopCount -= count;
            Save();
            return true;
        }

        private void Save()
        {
            PlayerData.SaveLollipop(LollipopCount);
            Debug.Log("Save");
        }

        private void Load()
        {
            LollipopCount = PlayerData.LoadLollipop();
            Debug.Log("Load");
        }
    }
}