using UnityEngine;

public class ChupaChupsMove : MonoBehaviour
{
    [Header("Float")]
    [SerializeField] private float _speed;
    [SerializeField] private float _minY;
    [SerializeField] private float _maxY;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;

    private void Update()
    {
        if(transform.position.y <= _minY)
        {
            var pos = new Vector2(Random.Range(_minX, _maxX + 1), _maxY);
            transform.position = pos;
        }

        transform.Translate(0, -_speed * Time.deltaTime, 0);
    }

    public void ResetChupaChups()
    {
        var pos = new Vector2(Random.Range(_minX, _maxX + 1), _maxY + 10f);
        transform.position = pos;
    }
}
