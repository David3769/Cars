using UnityEngine;

namespace Cars.Game
{
    public class RoadDrive : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _addingSpeedPerSecond;

        private float _sizeVertical;
        private float _positionVertical;

        private void Start()
        {
            _sizeVertical = GetComponent<SpriteRenderer>().bounds.size.y;
            Invoke("AddSpeed", 1f);
        }

        private void AddSpeed()
        {
            _speed += _addingSpeedPerSecond;
            Invoke("AddSpeed", 1f);
        }

        private void Update()
        {
            transform.position = UpdatePosition();
        }

        private Vector2 UpdatePosition()
        {
            _positionVertical -= _speed * Time.deltaTime;
            _positionVertical = Mathf.Repeat(_positionVertical, _sizeVertical);

            Vector2 newPosition = new Vector2(0, _positionVertical);
            return newPosition;
        }
    }
}

