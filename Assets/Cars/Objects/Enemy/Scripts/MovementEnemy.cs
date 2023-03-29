using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Enemy
{
    public class MovementEnemy : MonoBehaviour
    {
        [SerializeField] private RoadDrive _road;
        [SerializeField] private GameOver _gameOver;
        [SerializeField] private BoostEffect _effect;

        private float _speed;

        private void Start()
        {
            if (_road == null)
                _road = FindObjectOfType<RoadDrive>().GetComponent<RoadDrive>();

            if (_gameOver == null)
                _gameOver = FindObjectOfType<GameOver>().GetComponent<GameOver>();

            if (_effect == null)
                _effect = FindObjectOfType<BoostEffect>().GetComponent<BoostEffect>();
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

