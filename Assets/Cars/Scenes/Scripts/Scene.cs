using Cars.UI;
using UnityEngine;
using IJunior.TypedScenes;
using Cars.Player;

public class Scene : MonoBehaviour
{
    [SerializeField] private ChangeCar _changeCar;
    [SerializeField] private PlayerCar _playerCar;

    private void Start()
    {
        if (_changeCar == null)
            _changeCar = FindObjectOfType<ChangeCar>().GetComponent<ChangeCar>();

        if (_playerCar == null)
            _playerCar = FindObjectOfType<PlayerCar>().GetComponent<PlayerCar>();
    }

    public void SetSceneGame()
    {
        if (_changeCar != null && _playerCar != null)
        {
            var indexCar = ChangeCar.CurrentIndex;
            if (_playerCar.CheckOnMyCar(indexCar))
                Game.Load(indexCar);
        }
    }

    public void SetSceneMainMenu()
    {
        Main.Load();
    }
}
