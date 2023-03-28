using UnityEngine;
using Cars.Player;
using Cars.Data;
using System.Collections.Generic;
using IJunior.TypedScenes;
using Cars.UI;
using UnityEngine.SceneManagement;
using Cars.Game.Player;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] private PlayerCar _playerCar;
    [SerializeField] private GameOver _game;

    private void Start()
    {
        if (SceneController.IsCurrentNameScene("Main"))
            if (_playerCar == null)
                _playerCar = FindObjectOfType<PlayerCar>().GetComponent<PlayerCar>();
        else if (SceneController.IsCurrentNameScene("Game"))
            if (_game == null)
                _game = FindObjectOfType<GameOver>().GetComponent<GameOver>();
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
        _game.SetRestartGame();
    }
}


