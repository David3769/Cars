using UnityEngine;

namespace Cars.Game
{
    public class RoadDrive : MonoBehaviour
    {
        public static RoadDrive Instance { get; private set; }

        public float Speed = 1f;

        [SerializeField] private float _addingSpeedPerSecond;

        private float _driveDistance = 0;
        private float _sizeVertical;
        private float _positionVertical;

        private void Start()
        {
            if (Instance == null)
                Instance = this;

            _sizeVertical = GetComponent<SpriteRenderer>().bounds.size.y;

            Invoke(nameof(AddSpeed), 1f);
        }

        private void AddSpeed()
        {
            Speed += _addingSpeedPerSecond;
            Invoke(nameof(AddSpeed), 1f);
        }

        private void Update()
        {
            transform.position = UpdatePosition();
            _driveDistance += Speed * Time.deltaTime;
        }

        private Vector2 UpdatePosition()
        {
            _positionVertical -= Speed * Time.deltaTime;
            _positionVertical = Mathf.Repeat(_positionVertical, _sizeVertical);

            Vector2 newPosition = new Vector2(0, _positionVertical);
            return newPosition;
        }

        public int GetDriveDistance()
        {
            return Mathf.RoundToInt(_driveDistance);
        }
    }
}

