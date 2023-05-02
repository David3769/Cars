using UnityEngine;
using Cars.Game;
using UnityEngine.SceneManagement;
using Cars.Animation;

public class ButtonFunctions : MonoBehaviour
{
    public void ExitGame() => Application.Quit();

    public void RestartGame() => SceneManager.LoadScene(1);
}


