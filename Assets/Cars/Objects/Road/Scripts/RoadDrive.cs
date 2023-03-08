using UnityEngine;

namespace Cars.Game
{
    public class RoadDrive : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _addSpeed;

        private float _size;
        private float _position;

        private void Start()
        {
            _size = GetComponent<SpriteRenderer>().bounds.size.y;
        }

        private void Update()
        {
            transform.position = UpdatePosition();

            _speed += AddSpeedRoad();
        }

        private Vector2 UpdatePosition()
        {
            _position -= _speed * Time.deltaTime;
            _position = Mathf.Repeat(_position, _size);

            Vector2 newPosition = new Vector2(0, _position);

            return newPosition;
        }

        private float AddSpeedRoad()
        {
            return _addSpeed * Time.deltaTime;
        }
    }
}

