using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Enemy
{
    public class MovementEnemy : MonoBehaviour
    {
        [SerializeField] private RoadDrive _road;
        [SerializeField] private GameOver _gameOver;

        private float _speed;

        private void Start()
        {
            if (_road == null)
                _road = FindObjectOfType<RoadDrive>().GetComponent<RoadDrive>();

            if (_gameOver == null)
                _gameOver = FindObjectOfType<GameOver>().GetComponent<GameOver>();
        }

        private void Update()
        {
            _speed = _road.Speed + 3f;

            var newPosition = transform.position;
            newPosition.y -= _speed * Time.deltaTime;
            transform.position = newPosition;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayerMove>())
                _gameOver.SetGameOver();
        }
    }
}

