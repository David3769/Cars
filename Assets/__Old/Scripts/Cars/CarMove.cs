using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private GameObject _road;
    private GameObject _controllerUIGO;
    private RoadDrive _updateSpeed;
    private ControllerUIInGame _controllerUIInGame;

    private void Start()
    {
        _road = GameObject.FindGameObjectWithTag("Road");
        _updateSpeed = _road.GetComponent<RoadDrive>();
        _controllerUIGO = GameObject.FindGameObjectWithTag("ControllerUI");
        _controllerUIInGame = _controllerUIGO.GetComponent<ControllerUIInGame>();
    }

    private void Update()
    {
        if(_controllerUIInGame.isPause == true || _controllerUIInGame.isGameOver == true) return;

        if(transform.position.y <= -30f)
        {
            Destroy(this.gameObject);
        }

        _speed = _updateSpeed.speed + (_updateSpeed.speed * 1.7f);

        var position = new Vector2(transform.position.x, transform.position.y - _speed * Time.deltaTime);
        transform.position = position;
    }
}
