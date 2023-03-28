using Cars.UI;
using UnityEngine;
using IJunior.TypedScenes;
using Cars.Player;
using Cars.Game;

public class Scene : MonoBehaviour
{
    [SerializeField] private ChangeCar _changeCar;
    [SerializeField] private PlayerCar _playerCar;

    private void Start()
    {
        if (SceneController.IsCurrentNameScene("Main"))
        {
            if (_changeCar == null)
                _changeCar = FindObjectOfType<ChangeCar>().GetComponent<ChangeCar>();

            if (_playerCar == null)
                _playerCar = FindObjectOfType<PlayerCar>().GetComponent<PlayerCar>();
        }
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

    public void SetSceneMain()
    {
        Time.timeScale = 1f;
        StateManager.SetGame();
        Main.Load();
    }
}
