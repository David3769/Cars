using UnityEngine;

namespace Cars.Game
{
    public class RoadDrive : MonoBehaviour
    {
        public float Speed { get; private set; } = 1f;

        [SerializeField] private float _addingSpeedPerSecond;

        private float _driveDistance = 0;
        private float _sizeVertical;
        private float _positionVertical;

        private void Start()
        {
            _sizeVertical = GetComponent<SpriteRenderer>().bounds.size.y;

            Invoke("AddSpeed", 1f);
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

        private void AddSpeed()
        {
            Speed += _addingSpeedPerSecond;
            Invoke("AddSpeed", 1f);
        }

        public int GetDriveDistance()
        {
            return Mathf.RoundToInt(_driveDistance);
        }

        public void SaveDriveDistance()
        {
            if (PlayerPrefs.HasKey("distance"))
                PlayerPrefs.SetInt("distance", Mathf.RoundToInt(_driveDistance));
        }
    }
}

