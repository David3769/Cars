using Cars.Data;
using TMPro;
using UnityEngine;

namespace Cars.UI
{
    public class LollipopInUserMenu : MonoBehaviour
    {
        private void OnEnable()
        {
            var text = GetComponent<TMP_Text>();
            UpdateTextLollipop(text);
        }

        private static void UpdateTextLollipop(TMP_Text text)
        {
            var lollipops = PlayerDataHandler.Instance.Player.Lollipop;
            text.text = $"{lollipops}";
        }
    }
}
