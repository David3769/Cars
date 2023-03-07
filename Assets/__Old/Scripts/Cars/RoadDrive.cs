using UnityEngine;

public class RoadDrive : MonoBehaviour
{
    public float speed;
    
    [Header("Float")]
    [SerializeField] private float _addSpeed;
    [Header("Scripts")]
    [SerializeField] private ControllerUIInGame _controllerUIInGame;

    private float _size;
    private float _position;

    private void Start()
    {
        _size = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    private void Update()
    {
        if(_controllerUIInGame.isPause == true || _controllerUIInGame.isGameOver == true) return;

        _position -= speed * Time.deltaTime;
        _position = Mathf.Repeat(_position, _size);
        transform.position = new Vector2(0, _position);

        speed += _addSpeed * Time.deltaTime;
    }
}
