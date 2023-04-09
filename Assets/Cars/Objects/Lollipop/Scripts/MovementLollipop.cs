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
        [SerializeField] private int[] _addLollipops;
        [SerializeField] private float _yPositionForDelete;
        
        private BoostEffect _effect;

        private void Start()
        {
            if (_effect == null)
                _effect = BoostEffect.Instance;
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
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementPlayer>())
            {
                if (_effect.Effect == Effects.X2)
                {
                    _effect.SubtractEffect();
                    AddLollipop((int)AddCountLollipop.X2);
                }
                else
                    AddLollipop((int)AddCountLollipop.Default);
            }
        }

        private void AddLollipop(int boost)
        {
            var add = _addLollipops[Random.Range(0, _addLollipops.Length)] * boost;
            PlayerDataHandler.Instance.AddLollipop(add);
            LollipopUIDraw.Instance.UpdateLollipop();
            Respawn();
        }
    }
}
