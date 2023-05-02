using UnityEngine;

namespace Cars.Game
{
    public class RoadDrive : MonoBehaviour
    {
        public static RoadDrive Instance { get; private set; }

        public float Speed = 1;

        [SerializeField] private float _addingSpeedPerSecond;
        [SerializeField] private float _setStartCreateBoost;

        private float _score = 0;
        private float _sizeVertical;
        private float _positionVertical;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            _sizeVertical = GetComponent<SpriteRenderer>().bounds.size.y;
        }

        private void Update()
        {
            if (GameController.Instance.IsGame == true)
            {
                if (Speed >= _setStartCreateBoost)
                    if (CreateBoost.Instance.IsCreate == false)
                        CreateBoost.Instance.SetStartCreate();

                AddSpeed();
                transform.position = UpdatePosition();
                _score += Speed * Time.deltaTime;
            }
        }

        private void AddSpeed()
        {
            Speed += _addingSpeedPerSecond * Time.deltaTime;
        }

        private Vector2 UpdatePosition()
        {
            _positionVertical -= Speed * Time.deltaTime;
            _positionVertical = Mathf.Repeat(_positionVertical, _sizeVertical);

            Vector2 newPosition = new Vector2(0, _positionVertical);
            return newPosition;
        }

        public int GetScore()
        {
            return Mathf.RoundToInt(_score);
        }

        public int GetSpeed()
        {
            return Mathf.RoundToInt(Speed);
        }
    }
}

