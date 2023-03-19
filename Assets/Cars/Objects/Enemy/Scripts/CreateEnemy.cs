using UnityEngine;

namespace Cars.Game.Enemy
{
    public class CreateEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject[] _enemies;
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private float _speedCreate;

        private void Start()
        {
            Create();
        }

        private void Create()
        {
            Instantiate(_enemies[Random.Range(0, _enemies.Length)],
                        _spawnPoints[Random.Range(0, _spawnPoints.Length)]);

            Invoke("Create", _speedCreate);
        }
    }
}

