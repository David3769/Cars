using UnityEngine;

namespace Cars.Game
{
    public class BoostMove : MonoBehaviour
    {
        [SerializeField] private float _yPositionForDelete;
        [SerializeField] private Effects _giveEffect;

        private float _speed;
        private Color _color;

        private void Start()
        {
            _color = GetComponent<SpriteRenderer>().color;
            _speed = Random.Range(2f, 5f);
        }

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            if (transform.position.y <= _yPositionForDelete)
                Destroy(gameObject);

            transform.Translate(0f, -_speed * Time.deltaTime, 0f);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementPlayer>())
            {
                BoostEffect.Instance.SetEffect(_color, _giveEffect);
                Destroy(gameObject);
            }
        }
    }
}