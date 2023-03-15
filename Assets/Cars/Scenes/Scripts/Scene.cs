using Cars.UI;
using UnityEngine;
using IJunior.TypedScenes;
using Cars.Player;

public class Scene : MonoBehaviour
{
    [SerializeField] private ChangeCar _changeCar;
    [SerializeField] private PlayerCar _playerCar;

    public void SetSceneGame()
    {
        if (_changeCar != null && _playerCar != null)
        {
            var indexCar = _changeCar.CurrentIndex;
            if (_playerCar.CheckOnMyCar(indexCar))
                Game.Load(indexCar);
        }
    }

    public void SetSceneMainMenu()
    {
        Main.Load();
    }
}
