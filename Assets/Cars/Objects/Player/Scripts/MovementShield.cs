using UnityEngine;

namespace Cars.Game
{
    public class MovementShield : MonoBehaviour
    {
        private Transform _player;

        private void Start()
        {
            _player = FindObjectOfType<MovementPlayer>().GetComponent<Transform>();
        }

        private void Update()
        {
            transform.position = _player.position;
        }
    }
}
