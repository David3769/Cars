using System.Collections;
using UnityEngine;

namespace Cars.Game
{
    public class SpawnObjectsRoad : MonoBehaviour
    {
        public static SpawnObjectsRoad Instance { get; private set; }

        [SerializeField] private GameObject[] _objects;
        [SerializeField] private float _minTimeSpawn;
        [SerializeField] private float _maxTimeSpawn;
        [SerializeField] private Transform[] _spawnPoints;

        private void Start()
        {
            if (Instance == null)
                Instance = this;
        }

        public void SpawnObject()
        {
            Instantiate(_objects[Random.Range(0, _objects.Length)],
                _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);
        }
    }
}