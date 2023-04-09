using UnityEngine;
using IJunior.TypedScenes;
using Cars.Data;
using Cars.Game;

public class ChangeScene : MonoBehaviour
{
    public void SetSceneGame()
    {
        if (PlayerDataHandler.Instance.CheckOnMyCar())
        {
            Time.timeScale = 1f;
            StateManager.SetGame();
            Game.Load();
        }
    }

    public void SetSceneMain()
    {
        Main.Load();
        Time.timeScale = 1f;
        StateManager.SetGame();
    }
}
