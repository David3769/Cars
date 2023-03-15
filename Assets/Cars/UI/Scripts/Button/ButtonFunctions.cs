using UnityEngine;
using Cars.Player;
using Cars.Data;
using System.Collections.Generic;

public class ButtonFunctions : MonoBehaviour
{
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

    [SerializeField] private PlayerCar _playerCar;

    public void Load()
    {
        _playerCar.MyCar = GameFileHandler.Load<List<int>>();
    }
}


