using UnityEngine;
using IJunior.TypedScenes;

public class ButtonClickInMainScene : MonoBehaviour
{
    [SerializeField] private GameObject _loadingCanvas;
    [SerializeField] private GameObject _canvas;

    public void OnClick()
    {
        _loadingCanvas.SetActive(true);
        _canvas.SetActive(false);
        Loading.progress = 0;
        var isLoading = true;

        while(isLoading != false)
        {
            if(Loading.progress >= .9f)
            {
                //Play.Load();
                isLoading = false;
            }
        }      
    }
}
