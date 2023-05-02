using Cars.Audio;
using UnityEngine;

namespace Cars.Game
{
    public class MovementEnemy : MonoBehaviour
    {
        [SerializeField] private float _yPositionForDelete;

        private BoostEffect _effect;
        private float _speed;

        private void Start()
        {
            if (_effect == null)
                _effect = FindObjectOfType<BoostEffect>();
        }

        private void Update()
        {
            if (GameController.Instance.IsGame == true)
            {
                _speed = RoadDrive.Instance.Speed + 2f;
                Movement();
            }
        }

        private void Movement()
        {
            if (transform.position.y < _yPositionForDelete)
                Destroy(gameObject);
            transform.Translate(0, -_speed * Time.deltaTime, 0);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementPlayer>())
            {
                if (_effect.Effect == Effects.Shield)
                    _effect.SubtractEffect();
                else
                {
                    collision.GetComponent<MusicPlayerController>().PauseMusicEngine();
                    collision.GetComponent<MusicPlayerController>().PlayMusicEffectGameOver();
                    GameOver.Instance.SetGameOver();
                }
            }
        }
    }
}

