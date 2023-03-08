using UnityEngine;

public class RoadDrive : MonoBehaviour
{
    [SerializeField] private float _speed;
    //[SerializeField] private float _addSpeed;

    private float _size;
    private float _position;

    private void Start()
    {
        _size = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    private void Update()
    {
        _position -= _speed * Time.deltaTime;
        _position = Mathf.Repeat(_position, _size);
        transform.position = new Vector2(0, _position);

        //_speed += _addSpeed * Time.deltaTime;
    }
}
