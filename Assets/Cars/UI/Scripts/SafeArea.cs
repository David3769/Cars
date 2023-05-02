using UnityEngine;

namespace Cars.UI
{
    public class SafeArea : MonoBehaviour
    {
        private void Awake()
        {
            UpdateSafeArea();
        }

        private void UpdateSafeArea()
        {
            var safeArea = Screen.safeArea;
            var myRectTransform = GetComponent<RectTransform>();
            var anchorMin = safeArea.position;
            var anchorMax = safeArea.position + safeArea.size;

            UpdateAnchors(ref anchorMin, ref anchorMax);

            myRectTransform.anchorMin = anchorMin;
            myRectTransform.anchorMax = anchorMax;
        }

        private static void UpdateAnchors(ref Vector2 anchorMin, ref Vector2 anchorMax)
        {
            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;
        }
    }
}
