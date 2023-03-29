using UnityEngine;

namespace Cars.Game.Player
{
    public class BoostMove : MonoBehaviour
    {
        [SerializeField] private float _yPositionForDelete;
        [SerializeField] private Effects _giveEffect;

        private BoostEffect _effect;
        private float _speed;
        private Color _color;

        private void Start()
        {
            if (_effect == null)
                _effect = FindObjectOfType<BoostEffect>().GetComponent<BoostEffect>();

            _color = GetComponent<SpriteRenderer>().color;
            _speed = Random.Range(2f, 5f);
        }

        private void Update()
        {
            if (transform.position.y <= _yPositionForDelete)
                Destroy(gameObject);

            transform.Translate(0f, -_speed * Time.deltaTime, 0f);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayerMove>())
            {
                _effect.SetEffect(_color, _giveEffect);
                Destroy(gameObject);
            }
        }
    }
}