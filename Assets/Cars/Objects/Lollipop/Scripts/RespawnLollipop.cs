using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Lollipop
{
    public class RespawnLollipop : MonoBehaviour
    {
        [SerializeField] private Transform[] _respawnPoints;

        private GameObject _lollipop;

        private void Start()
        {
            if (_lollipop == null)
                _lollipop = FindObjectOfType<MovementLollipop>().gameObject;
        }

        public void Respawn()
        {
            _lollipop.transform.position = 
                _respawnPoints[Random.Range(0, _respawnPoints.Length - 1)]
                    .position;
        }
    }
}
