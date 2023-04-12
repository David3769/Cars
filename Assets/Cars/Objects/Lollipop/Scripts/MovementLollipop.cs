using Cars.Data;
using Cars.UI;
using UnityEngine;

namespace Cars.Game
{
    public class MovementLollipop : MonoBehaviour
    {
        enum AddCountLollipop
        {
            None,
            Default,
            X2
        }

        [SerializeField] private Transform[] _respawnPoints;
        [SerializeField] private float _speed;
        [SerializeField] private float _yPositionForDelete;
        [SerializeField] private Sprite[] _spriteLollipops;
        [SerializeField] private Sprite[] _spriteSticks;
        [SerializeField] private SpriteRenderer _chups;
        [SerializeField] private SpriteRenderer _stick;

        private BoostEffect _effect;
        private int _addLollipop = 1;

        private void Start()
        {
            if (_effect == null)
                _effect = BoostEffect.Instance;
            SetNewValues();
        }

        private void SetNewValues()
        {
            _addLollipop = Random.Range(1, 4);
            _chups.sprite = _spriteLollipops[_addLollipop - 1];
            _chups.color = new Color(Random.value, Random.value, Random.value, 1);
            _stick.sprite = _spriteSticks[_addLollipop - 1];
        }

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            if (transform.position.y <= _yPositionForDelete)
                Respawn();
            transform.Translate(0, -_speed * Time.deltaTime, 0);
        }

        public void Respawn()
        {
            transform.position =_respawnPoints[Random.Range(0, _respawnPoints.Length)].position;
            SetNewValues();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementPlayer>())
            {
                if (_effect.Effect == Effects.X2)
                {
                    _effect.SubtractEffect();
                    AddLollipop((int)AddCountLollipop.X2);
                    Respawn();
                }
                else
                {
                    AddLollipop((int)AddCountLollipop.Default);
                    Respawn();
                }
            }
        }

        private void AddLollipop(int boost)
        {
            var add = _addLollipop * boost;
            PlayerDataHandler.Instance.AddLollipop(add);
            LollipopUIDraw.Instance.UpdateLollipop();
        }
    }
}
