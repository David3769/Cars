using UnityEngine;

namespace Cars.Game
{
    public class MovementEnemy : MonoBehaviour
    {
        private BoostEffect _effect;
        private float _speed;

        private void Start()
        {
            if (_effect == null)
                _effect = FindObjectOfType<BoostEffect>();
        }

        private void Update()
        {
            _speed = RoadDrive.Instance.Speed + 3f;
            Movement();
        }

        private void Movement()
        {
            var newPosition = transform.position;
            newPosition.y -= _speed * Time.deltaTime;
            transform.position = newPosition;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementPlayer>())
            {
                if (_effect.Effect == Effects.Shield)
                    _effect.SubtractEffect();
                else
                    GameOver.Instance.SetGameOver();
            }
        }
    }
}

