using UnityEngine;

public class SpeedCreateCar : MonoBehaviour
{
    public float speedCreateCar;
    public float takeAwaySpeed;
    public float minSpeed;

    [SerializeField] private ControllerUIInGame _controllerUIInGame;

    private void Update()
    {
        if(_controllerUIInGame.isPause == true || _controllerUIInGame.isGameOver == true) return;
        if(speedCreateCar <= minSpeed) return;

        speedCreateCar -= takeAwaySpeed * Time.deltaTime;
    }
}
