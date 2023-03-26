using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Enemy
{
    public class MovementEnemy : MonoBehaviour
    {
        private RoadDrive _roadDrive;
        private GameOver _gameOver;
        private float _speed;

        private void Start()
        {
            _roadDrive = FindObjectOfType<RoadDrive>().GetComponent<RoadDrive>();
            _gameOver = FindObjectOfType<GameOver>().GetComponent<GameOver>();
        }

        private void Update()
        {
            _speed = _roadDrive.Speed + 3f;

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

