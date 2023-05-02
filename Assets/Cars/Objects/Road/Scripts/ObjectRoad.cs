using UnityEngine;

namespace Cars.Game
{
    public class ObjectRoad : MonoBehaviour
    {
        private const string NAME_TAG = "SetSpawnObject";
        private float _speed = 1f;

        private void Update()
        {
            if (GameController.Instance.IsGame == true)
            {
                _speed = RoadDrive.Instance.Speed;
                if (transform.position.y < -7f)
                    Destroy(gameObject);
                transform.Translate(0, -_speed * Time.deltaTime, 0);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(NAME_TAG))
                SpawnObjectsRoad.Instance.SpawnObject();
        }
    }
}
