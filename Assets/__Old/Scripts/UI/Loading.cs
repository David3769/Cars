using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField] private Image _loadingImg;
    
    public static float progress = 0;
    private void Update()
    {
        if(progress > 1)
        {
            return;
        }
        else
        {
            progress += Time.deltaTime;
            _loadingImg.fillAmount = progress;
        }
    }
}
