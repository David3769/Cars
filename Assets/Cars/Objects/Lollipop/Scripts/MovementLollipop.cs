using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Lollipop
{
    public class MovementLollipop : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private int[] _addLollipops;
        [SerializeField] private RespawnLollipop _respawnLollipop;
        [SerializeField] private float _yPositionForDelete;
        [SerializeField] private LollipopInGame _lollipop;
        [SerializeField] private BoostEffect _effect;

        private void Start()
        {
            if (_respawnLollipop == null)
                _respawnLollipop = FindObjectOfType<RespawnLollipop>()
                    .GetComponent<RespawnLollipop>();

            if (_lollipop == null)
                _lollipop = FindObjectOfType<LollipopInGame>()
                    .GetComponent<LollipopInGame>();

            if (_effect == null)
                _effect = FindObjectOfType<BoostEffect>()
                    .GetComponent<BoostEffect>();
        }

        private void Update()
        {
            if (transform.position.y <= _yPositionForDelete)
                Respawn();

            transform.Translate(0, -_speed * Time.deltaTime, 0);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayerMove>())
            {
                if (_effect.Effect == Effects.X2)
                {
                    _effect.SubtractEffect();
                    AddLollipop(2);
                }
                else
                {
                    AddLollipop(1);
                }
            }
        }

        private void AddLollipop(int boost)
        {
            var add = _addLollipops[Random.Range(0, _addLollipops.Length)] * boost;
            
            Respawn();
            _lollipop.AddLollipop(add);
        }

        public void Respawn()
        {
            _respawnLollipop.Respawn();
        }
    }
}
