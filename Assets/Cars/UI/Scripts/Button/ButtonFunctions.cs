using UnityEngine;
using Cars.Player;
using Cars.Data;
using System.Collections.Generic;
using IJunior.TypedScenes;
using Cars.UI;
using UnityEngine.SceneManagement;
using Cars.Game.Player;
using Cars.Game;

public class ButtonFunctions : MonoBehaviour
{
    [Header("Scene Main")]
    [SerializeField] private PlayerCar _playerCar;

    private void Start()
    {
        if (SceneController.IsCurrentNameScene("Main"))
            if (_playerCar == null)
                _playerCar = FindObjectOfType<PlayerCar>().GetComponent<PlayerCar>();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ResetCar()
    {
        int[] ints = { };

        GameFileHandler.Save(ints);
        ints = GameFileHandler.Load<int[]>();
    }

    public void Load()
    {
        _playerCar.MyCar = GameFileHandler.Load<List<int>>();
    }

    public void RestartGame()
    {
        Game.Load(ChangeCar.CurrentIndex);
        StateManager.SetGame();
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


