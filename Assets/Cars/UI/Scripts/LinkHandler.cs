using UnityEngine;

namespace Cars.UI
{
    public class LinkHandler : MonoBehaviour
    {
        public void OpenURL(string url) => Application.OpenURL(url);
    }
}