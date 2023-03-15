using TMPro;
using UnityEngine;

namespace Cars.UI
{
    enum NameSaveFile
    {
        Lollipop
    }

    public class Lollipop : MonoBehaviour
    {
        [SerializeField] private TMP_Text _lollipopUI;
        [SerializeField] private float _timeForSave;

        public int LollipopCount { get; private set; }

        private void Start()
        {
            if (PlayerPrefs.HasKey(NameSaveFile.Lollipop.ToString()) == true)
                LollipopCount = PlayerPrefs.GetInt(NameSaveFile.Lollipop.ToString());

            SaveLollipop();
        }

        private void SaveLollipop()
        {
            PlayerPrefs.SetInt(NameSaveFile.Lollipop.ToString(), LollipopCount);

            Invoke("SaveLollipop", _timeForSave);
        }

        private void Update()
        {
            if (_lollipopUI != null)
            {
                _lollipopUI.text = $"{LollipopCount}";
            }
        }

        public void Take(int count)
        {
            if (count <= 0 || count > LollipopCount)
                return;

            LollipopCount -= count;
        }
    }
}