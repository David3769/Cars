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

    private void Start()
    {
        if (_playerCar == null && SceneManager.GetActiveScene().name == "Main")
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

        IGameOver gameOver = new GameOver();
        gameOver.SetRestartGame();
    }
}


