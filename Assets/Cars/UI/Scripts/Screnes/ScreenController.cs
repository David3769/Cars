using UnityEngine;

namespace Cars.UI
{
    public class ScreenController : MonoBehaviour
    {
        [SerializeField] private string _tagScreen;

        public void OpenScreen(GameObject openScreen)
        {
            CloseLastScreen();
            openScreen.SetActive(true);
        }

        private void CloseLastScreen()
        {
            GameObject go = GameObject.FindWithTag(_tagScreen);
            go.SetActive(false);
        }
    }
}