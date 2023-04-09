using UnityEngine;
using IJunior.TypedScenes;
using Cars.Game;

public class ButtonFunctions : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        StateManager.SetGame();
        Game.Load();
    }

    public void SetPause()
    {
        StateManager.SetPause();
    }

    public void SetPlay()
    {
        StateManager.SetGame();
    }
}


