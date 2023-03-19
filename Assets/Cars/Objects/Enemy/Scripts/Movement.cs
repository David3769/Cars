using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Enemy
{
    public class Movement : MonoBehaviour
    {
        private float _speed = 5f;

        private void Update()
        {
            var newPosition = transform.position;
            newPosition.y -= _speed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}

