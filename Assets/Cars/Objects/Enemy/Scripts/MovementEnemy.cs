using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Enemy
{
    public class MovementEnemy : MonoBehaviour
    {
        private RoadDrive _road;
        private GameOver _gameOver;
        private BoostEffect _effect;
        private float _speed;

        private void Start()
        {
            if (_road == null)
                _road = FindObjectOfType<RoadDrive>();

            if (_gameOver == null)
                _gameOver = FindObjectOfType<GameOver>();

            if (_effect == null)
                _effect = FindObjectOfType<BoostEffect>();
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
            {
                if (_effect.Effect == Effects.Shield)
                    _effect.SubtractEffect();
                else
                    _gameOver.SetGameOver();
            }
        }
    }
}

