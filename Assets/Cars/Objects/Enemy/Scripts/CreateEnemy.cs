using UnityEngine;

namespace Cars.Game
{
    public class CreateEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject[] _enemies;
        [SerializeField] private Transform[] _spawnPoints;

        private void Start()
        {
            Create();
        }

        private void Create()
        {
            Instantiate(_enemies[Random.Range(0, _enemies.Length)],
                        _spawnPoints[Random.Range(0, _spawnPoints.Length)]);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<MovementEnemy>())
                Create();
        }
    }
}

