using UnityEngine;

namespace Cars.Game
{
    public class ObjectRoad : MonoBehaviour
    {
        private float _speed = 1f;

        private void Update()
        {
            _speed = RoadDrive.Instance.Speed;
            if (transform.position.y < -7f)
                Destroy(gameObject);
            transform.Translate(0, -_speed * Time.deltaTime, 0);
        }
    }
}
