using UnityEngine;

namespace Cars.Game
{
    public class BoostMove : MonoBehaviour
    {
        [SerializeField] private float _yPositionForDelete;
        [SerializeField] private Effects _giveEffect;

        private float _speed;

        private void Update()
        {
            if (GameController.Instance.IsGame == true)
                Movement();
        }

        private void Movement()
        {
            if (transform.position.y <= _yPositionForDelete)
                Destroy(gameObject);

            _speed = RoadDrive.Instance.Speed;
            transform.Translate(0f, -_speed * Time.deltaTime, 0f);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementPlayer>())
            {
                BoostEffect.Instance.SetEffect(_giveEffect);
                Destroy(gameObject);
            }
        }
    }
}