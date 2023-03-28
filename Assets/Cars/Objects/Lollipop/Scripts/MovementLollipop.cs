using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Lollipop
{
    public class MovementLollipop : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private int[] _addLollipops;
        [SerializeField] private RespawnLollipop _respawnLollipop;
        [SerializeField] private LollipopInGame _lollipop;

        private void Start()
        {
            if (_respawnLollipop == null)
                _respawnLollipop = FindObjectOfType<RespawnLollipop>()
                    .GetComponent<RespawnLollipop>();

            if (_lollipop == null)
                _lollipop = FindObjectOfType<LollipopInGame>()
                    .GetComponent<LollipopInGame>();
        }

        private void Update()
        {
            transform.Translate(0, -_speed * Time.deltaTime, 0);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayerMove>())
            {
                var add = _addLollipops[Random.Range(0, 
                    _addLollipops.Length - 1)];

                Respawn();
                _lollipop.AddLollipop(add);
            }
        }

        public void Respawn()
        {
            _respawnLollipop.Respawn();
        }
    }
}
